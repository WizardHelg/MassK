using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MassK
{
    class PulsTimer : Timer
    {
        Action _action;
        public void Puls(Action action)
        {
            Stop();
            _action = action;
            Start();
        }

        protected override void OnTick(EventArgs e)
        {
            _action?.Invoke();
            Stop();
            base.OnTick(e);
        }
    }
}
