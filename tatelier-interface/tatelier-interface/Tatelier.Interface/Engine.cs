using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatelier.Interface
{
	public abstract class Engine
	{
        #region シングルトン関連
        static Engine singleton;

		public static Engine Singleton => singleton;

		public static void Start(Engine engine)
		{
			singleton = engine;
		}
        #endregion

        public abstract IInput Input { get; }

		public abstract ILogWindow LogWindow { get; }

		public abstract INowTime NowTime { get; }

		public abstract IScreenSize ScreenSize { get; }

		public abstract Scene.ISceneControl SceneControl { get; }
	}
}
