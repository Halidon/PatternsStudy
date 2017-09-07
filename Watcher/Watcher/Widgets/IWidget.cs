using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watcher.Widgets
{
    public interface IWidget
    {
        void Update(string twitter, string lenta, string tv);
        void Display();
    }
}
