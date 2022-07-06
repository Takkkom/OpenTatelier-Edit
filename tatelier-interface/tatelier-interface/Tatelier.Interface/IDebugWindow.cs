using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatelier.Interface
{
	public interface IDebugWindow
	{
		void Start();
		void Update();
		void Draw();
		void Finish();
	}
}
