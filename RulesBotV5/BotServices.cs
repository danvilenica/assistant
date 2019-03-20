using Microsoft.Bot.Builder.AI.QnA;
using System;
using System.Collections.Generic;
using System.Text;

namespace RulesBotV5
{
    public class BotServices
    {
        public BotServices(Dictionary<string, QnAMaker> qnaServices)
        {
            QnAServices = qnaServices ?? throw new ArgumentNullException(nameof(qnaServices));
        }

        /// <summary>
        /// Gets the set of QnA Maker services used.
        /// Given there can be multiple <see cref="QnAMaker"/> services used in a single bot,
        /// QnA Maker instances are represented as a Dictionary.  This is also modeled in the
        /// ".bot" file using named elements.
        /// </summary>
        /// <remarks>The QnA Maker services collection should not be modified while the bot is running.</remarks>
        /// <value>
        /// A <see cref="QnAMaker"/> client instance created based on configuration in the .bot file.
        /// </value>
        public Dictionary<string, QnAMaker> QnAServices { get; } = new Dictionary<string, QnAMaker>();
    }
}
