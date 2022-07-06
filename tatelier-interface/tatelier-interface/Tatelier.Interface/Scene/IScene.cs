using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatelier.Interface.Scene
{
	public interface IScene
	{
		float Layer { get; set; }

		IDebugWindow DebugWindow { get; }

		int PreStart(params object[] args);

		IEnumerator<float> GetStartIterator();

		Command.ResultType CommandSearchAndRun(string command, params string[] args);

		void Start();
		void Update();
		void Draw();
		void Finish();

		int EnterTo(IScene to);

		void OnEnter(IScene sender);
		void OnLeave(IScene sender);
	}
}
