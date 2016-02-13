using System.Collections.Generic;
using System.Linq;
using System.Windows;
using Microsoft.VisualStudio.Text.Editor;

namespace VSDropAssist.DropActions
{
    internal class MessageBoxDropAction : DropActionBase
    {
        public   override DropActionResultEnum Execute(IEnumerable<Node> nodes, IWpfTextView textView)
        {

            var msg = string.Format("You dropped:\n{0}",
                string.Join("\n",
                    nodes.Select(x => string.Format("{0}.{1}.{2}.{3}", x.Assembly, x.Namespace, x.Type, x.Member))));
            _log.Debug(msg);
            MessageBox.Show(msg);

            return  DropActionResultEnum.None;
        }
    }
}