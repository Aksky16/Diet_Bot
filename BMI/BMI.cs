using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using AdaptiveExpressions.Properties;
using Microsoft.Bot.Builder.Dialogs;
using Newtonsoft.Json;

namespace BMI
{
    //Custom action
    public class BMI : Dialog
    {
        public BMI([CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0) : base()
        {
            RegisterSourceLocation(sourceFilePath, sourceLineNumber);
        }

        [JsonProperty("$Kind")]
        public const string Kind = "BMI";

        [JsonProperty("Weight")]
        public NumberExpression Weight { get; set; }

        [JsonProperty("Height")]
        public NumberExpression Height { get; set; }

        [JsonProperty("resultProperty")]
        public StringExpression ResultProperty { get; set; }

        public override Task<DialogTurnResult> BeginDialogAsync(DialogContext dc, object options = null,
            CancellationToken cancellationToken = new CancellationToken())
        {

            var w = Weight.GetValue(dc.State);
            var h = Height.GetValue(dc.State);
            var h2 = h * h;

            var ans = Convert.ToDecimal(w) / Convert.ToDecimal(h2);
            var result = Convert.ToDecimal(ans) * 10000;

            if (ResultProperty != null)
            {
                dc.State.SetValue(this.ResultProperty.GetValue(dc.State), result);
            }

            return dc.EndDialogAsync(result: result, cancellationToken: cancellationToken);
        }
    }
}
