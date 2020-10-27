using System;
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Model;
using Lusid.Sdk.Utilities;
using NUnit.Framework;

namespace Lusid.Sdk.Tests.Tutorials.Valuations
{
    [TestFixture]
    public class InLineBondValuation
    {
        private ILusidApiFactory _apiFactory;

        // This defines the scope that entities will be created in
        private const string TutorialScope = "Testdemo";


        [OneTimeSetUp]
        public void SetUp()
        {
            _apiFactory = LusidApiFactoryBuilder.Build("secrets.json");
        }
        
        [Test]
        public void Run_BondInLineValuation()
        {
            // Define a flow convention for the Bond
            // In this instance, the bond will pay a GBP coupon every 6 months
            // Accrued interest will be calculated on the ACT/365 day count convention
            
            var flowConventions = new FlowConventions(
                scope: null,
                code: null,
                currency: "GBP",
                paymentFrequency: "6M",
                rollConvention: FlowConventions.RollConventionEnum.MF,
                dayCountConvention: FlowConventions.DayCountConventionEnum.Act365,
                holidayCalendars: new List<string>(),
                settleDays: 2,
                resetDays: 2
            );
            
            // Use the GetValuationOfWeightedInstruments to price our Bond
            // We price the Bond for a date between the Bond's startDate and maturityDate

            ListAggregationResponse bondValuationResult = _apiFactory.Api<IAggregationApi>().GetValuationOfWeightedInstruments(
                new InlineValuationRequest(recipeId: new ResourceId(scope: "MyRecipeScope", code: "default"),
                    valuationSchedule: new ValuationSchedule(
                        effectiveFrom: new DateTimeOrCutLabel("2020-09-01"),
                        effectiveAt: new DateTimeOrCutLabel("2020-09-01"),
                        tenor: "1D"
                    ),
                    
                    metrics: new List<AggregateSpec>
                {
                    new AggregateSpec(key: "Instrument/default/Name", AggregateSpec.OpEnum.Value),
                    new AggregateSpec(key: "Holding/default/PV", AggregateSpec.OpEnum.Value),
                    new AggregateSpec(key: "Instrument/OTC/Bond/CashFlows", AggregateSpec.OpEnum.Value),
                    new AggregateSpec(key: "Instrument/OTC/Bond/AccruedInterest", AggregateSpec.OpEnum.Value)
                }, 
                    
                    instruments: new List<WeightedInstrument>
                {

                    new WeightedInstrument(
                        quantity: 1,
                        holdingIdentifier: "test-inline-val",
                        instrument: new Bond(
                            startDate: new DateTimeOffset(2020, 1, 1, 0, 0, 0,TimeSpan.Zero),
                            maturityDate: new DateTimeOffset(2021, 1, 1, 0, 0, 0,TimeSpan.Zero),
                            domCcy: "GBP",
                            flowConventions: flowConventions,
                            principal: 10000,
                            couponRate: new decimal(0.05),
                            identifiers: new Dictionary<string, string>(),
                            instrumentType: LusidInstrument.InstrumentTypeEnum.Bond
                        )
                        )
                }));
            
            // Test that the valuation engine returns a valid result
            Assert.That(bondValuationResult.Data, Has.Count.EqualTo(1));
            
            // Test that the PV calculation is what we expect
            Assert.That(bondValuationResult.Data[0]["Holding/default/PV"], Is.EqualTo(10336.986301369863));
        }
    }
}