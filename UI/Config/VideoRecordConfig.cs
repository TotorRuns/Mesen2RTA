using ReactiveUI.Fody.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesen.Config
{
	public class VideoRecordConfig : BaseConfig<VideoRecordConfig>
	{
		[Reactive] public VideoCodec Codec { get; set; } = VideoCodec.CSCD;
		[Reactive] public UInt32 CompressionLevel { get; set; } = 6;
		public bool RecordSystemHud { get; } = true;
		public bool RecordInputHud { get; } = true;
	}

	public enum VideoCodec
	{
		None = 0,
		ZMBV = 1,
		CSCD = 2,
		GIF = 3
	}
}
