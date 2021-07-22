using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Thinksquirrel.CShake;
using UnityEngine;

namespace Thinksquirrel.CShakeExample
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x2000009")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x17ED90", Offset = "0x17ED90")]
	[Attribute(Name = "RequireComponent", RVA = "0x17ED90", Offset = "0x17ED90")]
	public class CameraShakeExample : MonoBehaviour
	{
		// Token: 0x06000068 RID: 104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005C")]
		[Address(RVA = "0xCAC6D4", Offset = "0xCAC6D4", VA = "0x6CAC6D4")]
		public CameraShakeExample()
		{
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005D")]
		[Address(RVA = "0xCAC6F0", Offset = "0xCAC6F0", VA = "0x6CAC6F0")]
		private void Start()
		{
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005E")]
		[Address(RVA = "0xCAC830", Offset = "0xCAC830", VA = "0x6CAC830")]
		private void Update()
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005F")]
		[Address(RVA = "0xCACCB8", Offset = "0xCACCB8", VA = "0x6CACCB8")]
		private void OnShakeOffset(Vector3 translation, Quaternion rotation)
		{
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000060")]
		[Address(RVA = "0xCAD3A0", Offset = "0xCAD3A0", VA = "0x6CAD3A0")]
		private void Explosion()
		{
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000061")]
		[Address(RVA = "0xCAD554", Offset = "0xCAD554", VA = "0x6CAD554")]
		private void Footsteps()
		{
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000062")]
		[Address(RVA = "0xCAD588", Offset = "0xCAD588", VA = "0x6CAD588")]
		[DebuggerHidden]
		private IEnumerator DoFootsteps()
		{
			return null;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000063")]
		[Address(RVA = "0xCAD60C", Offset = "0xCAD60C", VA = "0x6CAD60C")]
		private void Earthquake()
		{
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000064")]
		[Address(RVA = "0xCAD658", Offset = "0xCAD658", VA = "0x6CAD658")]
		[DebuggerHidden]
		private IEnumerator DoEarthquake()
		{
			return null;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000065")]
		[Address(RVA = "0xCAD6DC", Offset = "0xCAD6DC", VA = "0x6CAD6DC")]
		[DebuggerHidden]
		private IEnumerator DoEarthquake2()
		{
			return null;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000066")]
		[Address(RVA = "0xCAD760", Offset = "0xCAD760", VA = "0x6CAD760")]
		public void OnShakeCamera()
		{
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000067")]
		[Address(RVA = "0xCAD790", Offset = "0xCAD790", VA = "0x6CAD790")]
		public void OnShakeEverything()
		{
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000068")]
		[Address(RVA = "0xCAD7C0", Offset = "0xCAD7C0", VA = "0x6CAD7C0")]
		public void OnNumberOfShakesSlider(float val)
		{
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000069")]
		[Address(RVA = "0xCAD7F4", Offset = "0xCAD7F4", VA = "0x6CAD7F4")]
		public void OnShakeAmountXSlider(float val)
		{
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006A")]
		[Address(RVA = "0xCAD85C", Offset = "0xCAD85C", VA = "0x6CAD85C")]
		public void OnShakeAmountYSlider(float val)
		{
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006B")]
		[Address(RVA = "0xCAD8C4", Offset = "0xCAD8C4", VA = "0x6CAD8C4")]
		public void OnShakeAmountZSlider(float val)
		{
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006C")]
		[Address(RVA = "0xCAD92C", Offset = "0xCAD92C", VA = "0x6CAD92C")]
		public void OnRotationAmountXSlider(float val)
		{
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006D")]
		[Address(RVA = "0xCAD994", Offset = "0xCAD994", VA = "0x6CAD994")]
		public void OnRotationAmountYSlider(float val)
		{
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006E")]
		[Address(RVA = "0xCAD9FC", Offset = "0xCAD9FC", VA = "0x6CAD9FC")]
		public void OnRotationAmountZSlider(float val)
		{
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006F")]
		[Address(RVA = "0xCADA64", Offset = "0xCADA64", VA = "0x6CADA64")]
		public void OnDistanceSlider(float val)
		{
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000070")]
		[Address(RVA = "0xCADA94", Offset = "0xCADA94", VA = "0x6CADA94")]
		public void OnSpeedSlider(float val)
		{
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000071")]
		[Address(RVA = "0xCADAC4", Offset = "0xCADAC4", VA = "0x6CADAC4")]
		public void OnDecaySlider(float val)
		{
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000072")]
		[Address(RVA = "0xCADAF4", Offset = "0xCADAF4", VA = "0x6CADAF4")]
		public void OnPresetExplosion()
		{
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000073")]
		[Address(RVA = "0xCADAF8", Offset = "0xCADAF8", VA = "0x6CADAF8")]
		public void OnPresetFootsteps()
		{
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000074")]
		[Address(RVA = "0xCADB2C", Offset = "0xCADB2C", VA = "0x6CADB2C")]
		public void OnPresetEarthquake()
		{
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000075")]
		[Address(RVA = "0xCADB30", Offset = "0xCADB30", VA = "0x6CADB30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1852E8", Offset = "0x1852E8")]
		private void <Explosion>m__0()
		{
		}

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0xC")]
		public bool is2DExample;

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x10")]
		public float rigidbodyForceModifier;

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x14")]
		public float rigidbodyTorqueModifier;

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x18")]
		private CanvasGroup m_Canvas;

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x1C")]
		private CameraShake m_Shake;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x20")]
		private bool m_ShakeEverything;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x24")]
		private Rigidbody[] m_Rigidbodies;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x28")]
		private Rigidbody2D[] m_Rigidbodies2D;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x2C")]
		private bool m_MultiShake;

		// Token: 0x0200000C RID: 12
		[Token(Token = "0x20002B7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F5E0", Offset = "0x17F5E0")]
		private sealed class <DoFootsteps>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			// Token: 0x06000082 RID: 130 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600144C")]
			[Address(RVA = "0xBD2E6C", Offset = "0xBD2E6C", VA = "0x6BD2E6C")]
			[DebuggerHidden]
			public <DoFootsteps>c__Iterator0()
			{
			}

			// Token: 0x06000083 RID: 131 RVA: 0x00002250 File Offset: 0x00000450
			[Token(Token = "0x600144D")]
			[Address(RVA = "0xBD2E74", Offset = "0xBD2E74", VA = "0x6BD2E74", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x06000084 RID: 132 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170001A5")]
			private object Current
			{
				[Token(Token = "0x600144E")]
				[Address(RVA = "0xBD3640", Offset = "0xBD3640", VA = "0x6BD3640", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x06000085 RID: 133 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170001A6")]
			private object Current
			{
				[Token(Token = "0x600144F")]
				[Address(RVA = "0xBD3648", Offset = "0xBD3648", VA = "0x6BD3648", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06000086 RID: 134 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001450")]
			[Address(RVA = "0xBD3650", Offset = "0xBD3650", VA = "0x6BD3650", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			// Token: 0x06000087 RID: 135 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001451")]
			[Address(RVA = "0xBD3664", Offset = "0xBD3664", VA = "0x6BD3664", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			// Token: 0x06000088 RID: 136 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001452")]
			[Address(RVA = "0xBD36EC", Offset = "0xBD36EC", VA = "0x6BD36EC")]
			internal void <>m__0()
			{
			}

			// Token: 0x04000063 RID: 99
			[Token(Token = "0x40012F1")]
			[FieldOffset(Offset = "0x8")]
			internal Vector3 <shake>__0;

			// Token: 0x04000064 RID: 100
			[Token(Token = "0x40012F2")]
			[FieldOffset(Offset = "0x14")]
			internal Vector3 <rot>__0;

			// Token: 0x04000065 RID: 101
			[Token(Token = "0x40012F3")]
			[FieldOffset(Offset = "0x20")]
			internal CameraShakeExample $this;

			// Token: 0x04000066 RID: 102
			[Token(Token = "0x40012F4")]
			[FieldOffset(Offset = "0x24")]
			internal object $current;

			// Token: 0x04000067 RID: 103
			[Token(Token = "0x40012F5")]
			[FieldOffset(Offset = "0x28")]
			internal bool $disposing;

			// Token: 0x04000068 RID: 104
			[Token(Token = "0x40012F6")]
			[FieldOffset(Offset = "0x2C")]
			internal int $PC;
		}

		// Token: 0x0200000D RID: 13
		[Token(Token = "0x20002B8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F5F0", Offset = "0x17F5F0")]
		private sealed class <DoEarthquake>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
		{
			// Token: 0x06000089 RID: 137 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001453")]
			[Address(RVA = "0xBD2A20", Offset = "0xBD2A20", VA = "0x6BD2A20")]
			[DebuggerHidden]
			public <DoEarthquake>c__Iterator1()
			{
			}

			// Token: 0x0600008A RID: 138 RVA: 0x00002268 File Offset: 0x00000468
			[Token(Token = "0x6001454")]
			[Address(RVA = "0xBD2A28", Offset = "0xBD2A28", VA = "0x6BD2A28", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x0600008B RID: 139 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170001A7")]
			private object Current
			{
				[Token(Token = "0x6001455")]
				[Address(RVA = "0xBD2D98", Offset = "0xBD2D98", VA = "0x6BD2D98", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x0600008C RID: 140 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170001A8")]
			private object Current
			{
				[Token(Token = "0x6001456")]
				[Address(RVA = "0xBD2DA0", Offset = "0xBD2DA0", VA = "0x6BD2DA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600008D RID: 141 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001457")]
			[Address(RVA = "0xBD2DA8", Offset = "0xBD2DA8", VA = "0x6BD2DA8", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			// Token: 0x0600008E RID: 142 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001458")]
			[Address(RVA = "0xBD2DBC", Offset = "0xBD2DBC", VA = "0x6BD2DBC", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			// Token: 0x0600008F RID: 143 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001459")]
			[Address(RVA = "0xBD2E44", Offset = "0xBD2E44", VA = "0x6BD2E44")]
			internal void <>m__0()
			{
			}

			// Token: 0x04000069 RID: 105
			[Token(Token = "0x40012F7")]
			[FieldOffset(Offset = "0x8")]
			internal Vector3 <shake>__0;

			// Token: 0x0400006A RID: 106
			[Token(Token = "0x40012F8")]
			[FieldOffset(Offset = "0x14")]
			internal Vector3 <rot>__0;

			// Token: 0x0400006B RID: 107
			[Token(Token = "0x40012F9")]
			[FieldOffset(Offset = "0x20")]
			internal int <i>__1;

			// Token: 0x0400006C RID: 108
			[Token(Token = "0x40012FA")]
			[FieldOffset(Offset = "0x24")]
			internal CameraShakeExample $this;

			// Token: 0x0400006D RID: 109
			[Token(Token = "0x40012FB")]
			[FieldOffset(Offset = "0x28")]
			internal object $current;

			// Token: 0x0400006E RID: 110
			[Token(Token = "0x40012FC")]
			[FieldOffset(Offset = "0x2C")]
			internal bool $disposing;

			// Token: 0x0400006F RID: 111
			[Token(Token = "0x40012FD")]
			[FieldOffset(Offset = "0x30")]
			internal int $PC;
		}

		// Token: 0x0200000E RID: 14
		[Token(Token = "0x20002B9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F600", Offset = "0x17F600")]
		private sealed class <DoEarthquake2>c__Iterator2 : IEnumerator, IDisposable, IEnumerator<object>
		{
			// Token: 0x06000090 RID: 144 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600145A")]
			[Address(RVA = "0xBD26FC", Offset = "0xBD26FC", VA = "0x6BD26FC")]
			[DebuggerHidden]
			public <DoEarthquake2>c__Iterator2()
			{
			}

			// Token: 0x06000091 RID: 145 RVA: 0x00002280 File Offset: 0x00000480
			[Token(Token = "0x600145B")]
			[Address(RVA = "0xBD2704", Offset = "0xBD2704", VA = "0x6BD2704", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700001C RID: 28
			// (get) Token: 0x06000092 RID: 146 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170001A9")]
			private object Current
			{
				[Token(Token = "0x600145C")]
				[Address(RVA = "0xBD2974", Offset = "0xBD2974", VA = "0x6BD2974", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x06000093 RID: 147 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170001AA")]
			private object Current
			{
				[Token(Token = "0x600145D")]
				[Address(RVA = "0xBD297C", Offset = "0xBD297C", VA = "0x6BD297C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06000094 RID: 148 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600145E")]
			[Address(RVA = "0xBD2984", Offset = "0xBD2984", VA = "0x6BD2984", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			// Token: 0x06000095 RID: 149 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600145F")]
			[Address(RVA = "0xBD2998", Offset = "0xBD2998", VA = "0x6BD2998", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			// Token: 0x04000070 RID: 112
			[Token(Token = "0x40012FE")]
			[FieldOffset(Offset = "0x8")]
			internal Vector3 <rot>__0;

			// Token: 0x04000071 RID: 113
			[Token(Token = "0x40012FF")]
			[FieldOffset(Offset = "0x14")]
			internal int <i>__1;

			// Token: 0x04000072 RID: 114
			[Token(Token = "0x4001300")]
			[FieldOffset(Offset = "0x18")]
			internal CameraShakeExample $this;

			// Token: 0x04000073 RID: 115
			[Token(Token = "0x4001301")]
			[FieldOffset(Offset = "0x1C")]
			internal object $current;

			// Token: 0x04000074 RID: 116
			[Token(Token = "0x4001302")]
			[FieldOffset(Offset = "0x20")]
			internal bool $disposing;

			// Token: 0x04000075 RID: 117
			[Token(Token = "0x4001303")]
			[FieldOffset(Offset = "0x24")]
			internal int $PC;
		}
	}
}
