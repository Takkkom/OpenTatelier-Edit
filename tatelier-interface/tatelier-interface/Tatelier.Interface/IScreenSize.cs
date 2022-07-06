using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatelier.Interface
{
	/// <summary>
	/// スクリーンサイズインターフェース
	/// </summary>
	public interface IScreenSize
	{
		/// <summary>
		/// 幅
		/// </summary>
		int Width { get; }

		/// <summary>
		/// 高さ
		/// </summary>
		int Height { get; }
	}
}
