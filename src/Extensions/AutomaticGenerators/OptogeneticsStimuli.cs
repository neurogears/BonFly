
using Bonsai;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using YamlDotNet.Serialization;
using System.IO;
using YamlDotNet.Serialization.NamingConventions;
using YamlDotNet.Core;
using AutomaticGenerators;

namespace AutomaticGenerators
{
    [Combinator]
    [Description("Constructor.")]
    [WorkflowElementCategory(ElementCategory.Source)]
    public partial class OptogeneticsStimuli
    {
        public IObservable<OptogeneticsStimuli> Process()
        {
            return Observable.Defer(() =>
            {
                var value = new OptogeneticsStimuli
                {
					Amplitude = Amplitude,
					Duration = Duration,
					DutyCycle = DutyCycle,
					Frequency = Frequency,
					LedTarget = LedTarget,
					Mode = Mode,
					AdditionalProperties = AdditionalProperties,

                };
                return Observable.Return(value);
            });
        }
    }
}
