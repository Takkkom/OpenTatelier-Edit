namespace Tatelier.Interface.Scene
{
    public interface ISceneControl
	{
		/// <summary>
		/// カレントシーンかどうか判定する。
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <returns></returns>
		bool IsCurrentScene<T>()
			where T : Scene.IScene;

		/// <summary>
		/// シーンを作成する。
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="name"></param>
		/// <param name="scene"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		int CreateScene<T>(string name, out T scene, params object[] args)
			where T : Scene.IScene, new();
	}
}
