using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfTutorialSamples.Rich_text_controls
{
    /// <summary>
    /// Interaction logic for CodeBehindFlowDocumentSample.xaml
    /// </summary>
    public partial class CodeBehindFlowDocumentSample : Window
    {
        public CodeBehindFlowDocumentSample()
        {
            InitializeComponent();

            FlowDocument doc = new FlowDocument();

            Paragraph p = new Paragraph(new Run("Hello, world!"));
            p.FontSize = 36;
            doc.Blocks.Add(p);

            p = new Paragraph(new Run("The ultimate programming greeting!"));
            p.FontSize = 14;
            p.FontStyle = FontStyles.Italic;
            p.TextAlignment = TextAlignment.Left;
            p.Foreground = Brushes.Gray;
            doc.Blocks.Add(p);

            fdViewer.Document = doc;
        }
    }
}
