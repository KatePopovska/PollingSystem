﻿using PollingSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

    public class PollResults
    {
        private readonly Poll _poll;

        public PollResults(Poll poll)
        {
            _poll = poll;
        }

        public string GetView()
        {
            var stringBuilder = new StringBuilder(_poll.QuestionText);
            stringBuilder.AppendLine("-".PadLeft(50));
            if (_poll.Answers != null && _poll.Answers.Any())
            {
                _poll.Answers.ForEach(x => stringBuilder.AppendLine(x.ToString()));
            }
            return stringBuilder.ToString();
        }
    }
