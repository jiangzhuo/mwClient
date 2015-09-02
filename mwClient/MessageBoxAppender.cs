using log4net.Appender;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net.Core;
using System.Windows.Forms;
using System.Diagnostics;

namespace mwClient
{
    public class MessageBoxAppender : AppenderSkeleton
    {
        /// <summary>
        /// Writes the logging event to a MessageBox
        /// </summary>
        override protected void Append(LoggingEvent loggingEvent)
        {
            string title = string.Format("{0} {1}",
                loggingEvent.Level.DisplayName,
                loggingEvent.LoggerName);

            string message = string.Format(
                "{0}{1}{1}{2}{1}{1}(Yes to continue, No to debug)",
                RenderLoggingEvent(loggingEvent),
                Environment.NewLine,
                loggingEvent.LocationInformation.FullInfo);

            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                Debugger.Break();
            }
        }

        /// <summary>
        /// This appender requires a <see cref="Layout"/> to be set.
        /// </summary>
        override protected bool RequiresLayout
        {
            get { return true; }
        }
    }
}
