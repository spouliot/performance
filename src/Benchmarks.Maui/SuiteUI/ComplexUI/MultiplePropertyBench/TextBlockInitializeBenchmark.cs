using Benchmarks.Maui.Benchmarking;

namespace Benchmarks.Maui.SuiteUI.ComplexUI.MultiplePropertyBench
{
    internal class TextBlockInitializeBenchmark : IAsyncUIBenchmark
    {
        public Task BenchmarkAsync()
        {
            var label = new Label()
            {
                FontFamily = "Courier New",
                FontSize = 20d,
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
                TextColor = Colors.Red,
                HorizontalTextAlignment = TextAlignment.End,
                Text = "TYPo",
                TextDecorations = TextDecorations.Strikethrough,
                WidthRequest = 150d
            };

            return Task.CompletedTask;
        }
    }
}