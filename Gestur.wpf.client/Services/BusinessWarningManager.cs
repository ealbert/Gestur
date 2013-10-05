using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Gestur.Core.Message;
using Hardcodet.Wpf.TaskbarNotification;

namespace Gestur.wpf.client.Services
{
    class BusinessWarningManager
        : IBusinessWarningManager
    {
        private readonly TaskbarIcon _warningNotifierInstance;

        public BusinessWarningManager()
        {
            _warningNotifierInstance = new TaskbarIcon { Icon = new Icon(@"./Resources/Icons/Warning.ico") };
        }

        public void HandleBusinessWarning(IEnumerable<BusinessWarning> warnings)
        {
            var message = string.Join(Environment.NewLine, warnings.Select(w => w.Message));
            _warningNotifierInstance.ShowBalloonTip("eDirectory - Warning",
                                                   message,
                                                   BalloonIcon.Info);
        }
    }
}
