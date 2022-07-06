using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatelier.Interface
{
    /// <summary>
    /// 現在時間取得インターフェース
    /// </summary>
	public interface INowTime
    {
        /// <summary>
        /// ミリ秒
        /// </summary>
        int Millisec { get; }

        /// <summary>
        /// マイクロ秒
        /// </summary>
        long Microsec { get; }
    }
}
