using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Thinksquirrel.CShake
{
	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x17ECB8", Offset = "0x17ECB8")]
	[Attribute(Name = "CameraShakeDocumentationName", RVA = "0x17ECB8", Offset = "0x17ECB8")]
	public class CameraShake : CameraShakeBase
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000003")]
		[Address(RVA = "0xCA4120", Offset = "0xCA4120", VA = "0x6CA4120")]
		public CameraShake()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000001")]
		public List<Camera> cameras
		{
			[Token(Token = "0x6000004")]
			[Address(RVA = "0xCA43B0", Offset = "0xCA43B0", VA = "0x6CA43B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000005")]
			[Address(RVA = "0xCA43B8", Offset = "0xCA43B8", VA = "0x6CA43B8")]
			set
			{
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002058 File Offset: 0x00000258
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000002")]
		public CameraShake.ShakeType shakeType
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0xCA43C0", Offset = "0xCA43C0", VA = "0x6CA43C0")]
			get
			{
				return CameraShake.ShakeType.CameraMatrix;
			}
			[Token(Token = "0x6000007")]
			[Address(RVA = "0xCA43C8", Offset = "0xCA43C8", VA = "0x6CA43C8")]
			set
			{
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002070 File Offset: 0x00000270
		// (set) Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000003")]
		public int numberOfShakes
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0xCA43D0", Offset = "0xCA43D0", VA = "0x6CA43D0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000009")]
			[Address(RVA = "0xCA43D8", Offset = "0xCA43D8", VA = "0x6CA43D8")]
			set
			{
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002088 File Offset: 0x00000288
		// (set) Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000004")]
		public Vector3 shakeAmount
		{
			[Token(Token = "0x600000A")]
			[Address(RVA = "0xCA43E0", Offset = "0xCA43E0", VA = "0x6CA43E0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600000B")]
			[Address(RVA = "0xCA43F4", Offset = "0xCA43F4", VA = "0x6CA43F4")]
			set
			{
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000020A0 File Offset: 0x000002A0
		// (set) Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000005")]
		public Vector3 rotationAmount
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0xCA4400", Offset = "0xCA4400", VA = "0x6CA4400")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600000D")]
			[Address(RVA = "0xCA4414", Offset = "0xCA4414", VA = "0x6CA4414")]
			set
			{
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000020B8 File Offset: 0x000002B8
		// (set) Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000006")]
		public float distance
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0xCA4420", Offset = "0xCA4420", VA = "0x6CA4420")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600000F")]
			[Address(RVA = "0xCA4428", Offset = "0xCA4428", VA = "0x6CA4428")]
			set
			{
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000020D0 File Offset: 0x000002D0
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000007")]
		public float speed
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0xCA4430", Offset = "0xCA4430", VA = "0x6CA4430")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000011")]
			[Address(RVA = "0xCA4438", Offset = "0xCA4438", VA = "0x6CA4438")]
			set
			{
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000012 RID: 18 RVA: 0x000020E8 File Offset: 0x000002E8
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000008")]
		public float decay
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0xCA4440", Offset = "0xCA4440", VA = "0x6CA4440")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000013")]
			[Address(RVA = "0xCA4448", Offset = "0xCA4448", VA = "0x6CA4448")]
			set
			{
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002100 File Offset: 0x00000300
		// (set) Token: 0x06000015 RID: 21 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000009")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x188E3C", Offset = "0x188E3C")]
		public float guiShakeModifier
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0xCA4450", Offset = "0xCA4450", VA = "0x6CA4450")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000015")]
			[Address(RVA = "0xCA4460", Offset = "0xCA4460", VA = "0x6CA4460")]
			set
			{
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002118 File Offset: 0x00000318
		// (set) Token: 0x06000017 RID: 23 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000A")]
		public float uiShakeModifier
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0xCA4458", Offset = "0xCA4458", VA = "0x6CA4458")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000017")]
			[Address(RVA = "0xCA4468", Offset = "0xCA4468", VA = "0x6CA4468")]
			set
			{
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00002130 File Offset: 0x00000330
		// (set) Token: 0x06000019 RID: 25 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000B")]
		public bool multiplyByTimeScale
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0xCA4470", Offset = "0xCA4470", VA = "0x6CA4470")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000019")]
			[Address(RVA = "0xCA4478", Offset = "0xCA4478", VA = "0x6CA4478")]
			set
			{
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002148 File Offset: 0x00000348
		// (set) Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000C")]
		public Rect uiShakeRect
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0xCA4480", Offset = "0xCA4480", VA = "0x6CA4480")]
			get
			{
				return default(Rect);
			}
			[Token(Token = "0x600001B")]
			[Address(RVA = "0xCA4490", Offset = "0xCA4490", VA = "0x6CA4490")]
			set
			{
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700000D")]
		public static CameraShake instance
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0xCA44A0", Offset = "0xCA44A0", VA = "0x6CA44A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001D")]
		[Address(RVA = "0xCA45D4", Offset = "0xCA45D4", VA = "0x6CA45D4")]
		private void OnEnable()
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001E")]
		[Address(RVA = "0xCA4990", Offset = "0xCA4990", VA = "0x6CA4990")]
		private void OnDisable()
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600001F")]
		[Address(RVA = "0xCA4A4C", Offset = "0xCA4A4C", VA = "0x6CA4A4C")]
		public static CameraShake[] GetComponents()
		{
			return null;
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00002160 File Offset: 0x00000360
		[Token(Token = "0x1700000E")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x188E90", Offset = "0x188E90")]
		public static bool isShaking
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0xCA4B00", Offset = "0xCA4B00", VA = "0x6CA4B00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00002178 File Offset: 0x00000378
		[Token(Token = "0x1700000F")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x188EF8", Offset = "0x188EF8")]
		public static bool isCancelling
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0xCA4C74", Offset = "0xCA4C74", VA = "0x6CA4C74")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000022")]
		[Address(RVA = "0xCA4E1C", Offset = "0xCA4E1C", VA = "0x6CA4E1C")]
		public static void ShakeAll()
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000023")]
		[Address(RVA = "0xCA5104", Offset = "0xCA5104", VA = "0x6CA5104")]
		public static void ShakeAll(CameraShake.ShakeType shakeType, int numberOfShakes, Vector3 shakeAmount, Vector3 rotationAmount, float distance, float speed, float decay, float uiShakeModifier, bool multiplyByTimeScale)
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000024")]
		[Address(RVA = "0xCA5484", Offset = "0xCA5484", VA = "0x6CA5484")]
		public static void ShakeAll(Action callback)
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000025")]
		[Address(RVA = "0xCA5790", Offset = "0xCA5790", VA = "0x6CA5790")]
		public static void ShakeAll(CameraShake.ShakeType shakeType, int numberOfShakes, Vector3 shakeAmount, Vector3 rotationAmount, float distance, float speed, float decay, float uiShakeModifier, bool multiplyByTimeScale, Action callback)
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000026")]
		[Address(RVA = "0xCA5B18", Offset = "0xCA5B18", VA = "0x6CA5B18")]
		public static void CancelAllShakes()
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000027")]
		[Address(RVA = "0xCA5DF0", Offset = "0xCA5DF0", VA = "0x6CA5DF0")]
		public static void CancelAllShakes(float time)
		{
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000028 RID: 40 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000029 RID: 41 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000001")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x188D9C", Offset = "0x188D9C")]
		public event Action cameraShakeStarted
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0xCA5FC8", Offset = "0xCA5FC8", VA = "0x6CA5FC8")]
			add
			{
			}
			[Token(Token = "0x6000029")]
			[Address(RVA = "0xCA6084", Offset = "0xCA6084", VA = "0x6CA6084")]
			remove
			{
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600002A RID: 42 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600002B RID: 43 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000002")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x188DF0", Offset = "0x188DF0")]
		public event Action allCameraShakesCompleted
		{
			[Token(Token = "0x600002A")]
			[Address(RVA = "0xCA6140", Offset = "0xCA6140", VA = "0x6CA6140")]
			add
			{
			}
			[Token(Token = "0x600002B")]
			[Address(RVA = "0xCA61FC", Offset = "0xCA61FC", VA = "0x6CA61FC")]
			remove
			{
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600002C RID: 44 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600002D RID: 45 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000003")]
		public event Action onStartShaking
		{
			[Token(Token = "0x600002C")]
			[Address(RVA = "0xCA5FCC", Offset = "0xCA5FCC", VA = "0x6CA5FCC")]
			add
			{
			}
			[Token(Token = "0x600002D")]
			[Address(RVA = "0xCA6088", Offset = "0xCA6088", VA = "0x6CA6088")]
			remove
			{
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600002E RID: 46 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600002F RID: 47 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000004")]
		public event Action onEndShaking
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0xCA6144", Offset = "0xCA6144", VA = "0x6CA6144")]
			add
			{
			}
			[Token(Token = "0x600002F")]
			[Address(RVA = "0xCA6200", Offset = "0xCA6200", VA = "0x6CA6200")]
			remove
			{
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000030 RID: 48 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000031 RID: 49 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000005")]
		public event Action onPreShake
		{
			[Token(Token = "0x6000030")]
			[Address(RVA = "0xCA62B8", Offset = "0xCA62B8", VA = "0x6CA62B8")]
			add
			{
			}
			[Token(Token = "0x6000031")]
			[Address(RVA = "0xCA6370", Offset = "0xCA6370", VA = "0x6CA6370")]
			remove
			{
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000032 RID: 50 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000033 RID: 51 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000006")]
		public event Action onPostShake
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0xCA6428", Offset = "0xCA6428", VA = "0x6CA6428")]
			add
			{
			}
			[Token(Token = "0x6000033")]
			[Address(RVA = "0xCA64E0", Offset = "0xCA64E0", VA = "0x6CA64E0")]
			remove
			{
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000034 RID: 52 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000035 RID: 53 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000007")]
		public event Action<Vector3, Quaternion> onShakeOffset
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0xCA6598", Offset = "0xCA6598", VA = "0x6CA6598")]
			add
			{
			}
			[Token(Token = "0x6000035")]
			[Address(RVA = "0xCA6650", Offset = "0xCA6650", VA = "0x6CA6650")]
			remove
			{
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002190 File Offset: 0x00000390
		[Token(Token = "0x6000036")]
		[Address(RVA = "0xCA4C6C", Offset = "0xCA4C6C", VA = "0x6CA4C6C")]
		public bool IsShaking()
		{
			return default(bool);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000021A8 File Offset: 0x000003A8
		[Token(Token = "0x6000037")]
		[Address(RVA = "0xCA4E14", Offset = "0xCA4E14", VA = "0x6CA4E14")]
		public bool IsCancelling()
		{
			return default(bool);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000038")]
		[Address(RVA = "0xCA4F78", Offset = "0xCA4F78", VA = "0x6CA4F78")]
		public void Shake()
		{
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000039")]
		[Address(RVA = "0xCA52EC", Offset = "0xCA52EC", VA = "0x6CA52EC")]
		public void Shake(CameraShake.ShakeType shakeType, int numberOfShakes, Vector3 shakeAmount, Vector3 rotationAmount, float distance, float speed, float decay, float uiShakeModifier, bool multiplyByTimeScale)
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003A")]
		[Address(RVA = "0xCA55F0", Offset = "0xCA55F0", VA = "0x6CA55F0")]
		public void Shake(Action callback)
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003B")]
		[Address(RVA = "0xCA5980", Offset = "0xCA5980", VA = "0x6CA5980")]
		public void Shake(CameraShake.ShakeType shakeType, int numberOfShakes, Vector3 shakeAmount, Vector3 rotationAmount, float distance, float speed, float decay, float uiShakeModifier, bool multiplyByTimeScale, Action callback)
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003C")]
		[Address(RVA = "0xCA5C74", Offset = "0xCA5C74", VA = "0x6CA5C74")]
		public void CancelShake()
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003D")]
		[Address(RVA = "0xCA5F5C", Offset = "0xCA5F5C", VA = "0x6CA5F5C")]
		public void CancelShake(float time)
		{
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003E")]
		[Address(RVA = "0xCA6ADC", Offset = "0xCA6ADC", VA = "0x6CA6ADC")]
		public void BeginShakeGUI()
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003F")]
		[Address(RVA = "0xCA6D00", Offset = "0xCA6D00", VA = "0x6CA6D00")]
		public void EndShakeGUI()
		{
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000040")]
		[Address(RVA = "0xCA6D7C", Offset = "0xCA6D7C", VA = "0x6CA6D7C")]
		public void BeginShakeGUILayout()
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000041")]
		[Address(RVA = "0xCA6DAC", Offset = "0xCA6DAC", VA = "0x6CA6DAC")]
		public void EndShakeGUILayout()
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000042")]
		[Address(RVA = "0xCA6DB4", Offset = "0xCA6DB4", VA = "0x6CA6DB4")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000043")]
		[Address(RVA = "0xCA6708", Offset = "0xCA6708", VA = "0x6CA6708")]
		[DebuggerHidden]
		private IEnumerator DoShake_Internal(Camera cam, Vector3 seed, CameraShake.ShakeType shakeType, int numberOfShakes, Vector3 shakeAmount, Vector3 rotationAmount, float distance, float speed, float decay, float uiShakeModifier, bool multiplyByTimeScale, Action callback)
		{
			return null;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000044")]
		[Address(RVA = "0xCA6B8C", Offset = "0xCA6B8C", VA = "0x6CA6B8C")]
		private void CheckShakeRect()
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000045")]
		[Address(RVA = "0xCA6914", Offset = "0xCA6914", VA = "0x6CA6914")]
		private void ResetState(Camera cam)
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000046")]
		[Address(RVA = "0xCA6A00", Offset = "0xCA6A00", VA = "0x6CA6A00")]
		[DebuggerHidden]
		private IEnumerator DoResetState(IList<Camera> cameras, IDictionary<Camera, int> shakeCount, float time)
		{
			return null;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000021C0 File Offset: 0x000003C0
		[Token(Token = "0x6000047")]
		[Address(RVA = "0xCA7C70", Offset = "0xCA7C70", VA = "0x6CA7C70")]
		private static Vector3 GetGeometricAvg(IList<CameraShake.ShakeState> states, bool position)
		{
			return default(Vector3);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000021D8 File Offset: 0x000003D8
		[Token(Token = "0x6000048")]
		[Address(RVA = "0xCA7F74", Offset = "0xCA7F74", VA = "0x6CA7F74")]
		private static Quaternion GetAvgRotation(IList<CameraShake.ShakeState> states)
		{
			return default(Quaternion);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000021F0 File Offset: 0x000003F0
		[Token(Token = "0x6000049")]
		[Address(RVA = "0xCA83FC", Offset = "0xCA83FC", VA = "0x6CA83FC")]
		private static float GetPixelWidth(Transform cachedTransform, Camera cachedCamera)
		{
			return 0f;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002208 File Offset: 0x00000408
		[Token(Token = "0x600004A")]
		[Address(RVA = "0xCA7AC8", Offset = "0xCA7AC8", VA = "0x6CA7AC8")]
		private static Quaternion QuaternionFromMatrix(Matrix4x4 m)
		{
			return default(Quaternion);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004B")]
		[Address(RVA = "0xCA8824", Offset = "0xCA8824", VA = "0x6CA8824")]
		private static void NormalizeQuaternion(ref Quaternion q)
		{
		}

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		private List<Camera> m_Cameras;

		// Token: 0x04000003 RID: 3
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private CameraShake.ShakeType m_ShakeType;

		// Token: 0x04000004 RID: 4
		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private int m_NumberOfShakes;

		// Token: 0x04000005 RID: 5
		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Vector3 m_ShakeAmount;

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Vector3 m_RotationAmount;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_Distance;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_Speed;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_Decay;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float m_UiShakeModifier;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool m_MultiplyByTimeScale;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x44")]
		private Rect m_ShakeRect;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x54")]
		private bool m_Shaking;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x55")]
		private bool m_Cancelling;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x58")]
		private readonly List<Vector3> m_MatrixOffsetCache;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x5C")]
		private readonly List<Quaternion> m_MatrixRotationCache;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x60")]
		private readonly List<Vector3> m_OffsetCache;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x64")]
		private readonly List<Quaternion> m_RotationCache;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x68")]
		private readonly List<bool> m_IgnoreMatrixCache;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x6C")]
		private readonly List<bool> m_IgnorePositionCache;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x70")]
		private readonly Dictionary<Camera, List<CameraShake.ShakeState>> m_States;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x74")]
		private readonly Dictionary<Camera, int> m_ShakeCount;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		private const float minShakeValue = 0.001f;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		private const float minRotationValue = 0.001f;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<CameraShake> m_Components;

		// Token: 0x02000004 RID: 4
		[Token(Token = "0x2000004")]
		public enum ShakeType
		{
			// Token: 0x04000020 RID: 32
			[Token(Token = "0x4000020")]
			CameraMatrix,
			// Token: 0x04000021 RID: 33
			[Token(Token = "0x4000021")]
			LocalPosition
		}

		// Token: 0x02000005 RID: 5
		[Token(Token = "0x2000005")]
		internal class ShakeState
		{
			// Token: 0x0600004D RID: 77 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600004D")]
			[Address(RVA = "0xCABEB0", Offset = "0xCABEB0", VA = "0x6CABEB0")]
			internal ShakeState(CameraShake.ShakeType shakeType, Vector3 position, Quaternion rotation, Vector2 uiPosition)
			{
			}

			// Token: 0x04000022 RID: 34
			[Token(Token = "0x4000022")]
			[FieldOffset(Offset = "0x8")]
			internal readonly CameraShake.ShakeType _shakeType;

			// Token: 0x04000023 RID: 35
			[Token(Token = "0x4000023")]
			[FieldOffset(Offset = "0xC")]
			internal readonly Vector3 _startPosition;

			// Token: 0x04000024 RID: 36
			[Token(Token = "0x4000024")]
			[FieldOffset(Offset = "0x18")]
			internal readonly Quaternion _startRotation;

			// Token: 0x04000025 RID: 37
			[Token(Token = "0x4000025")]
			[FieldOffset(Offset = "0x28")]
			internal readonly Vector2 _uiStartPosition;

			// Token: 0x04000026 RID: 38
			[Token(Token = "0x4000026")]
			[FieldOffset(Offset = "0x30")]
			internal Vector3 _shakePosition;

			// Token: 0x04000027 RID: 39
			[Token(Token = "0x4000027")]
			[FieldOffset(Offset = "0x3C")]
			internal Quaternion _shakeRotation;

			// Token: 0x04000028 RID: 40
			[Token(Token = "0x4000028")]
			[FieldOffset(Offset = "0x4C")]
			internal Vector2 _uiShakePosition;
		}

		// Token: 0x02000006 RID: 6
		[Token(Token = "0x20002B5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F5C0", Offset = "0x17F5C0")]
		private sealed class <DoShake_Internal>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			// Token: 0x0600004E RID: 78 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001440")]
			[Address(RVA = "0xCA7C60", Offset = "0xCA7C60", VA = "0x6CA7C60")]
			[DebuggerHidden]
			public <DoShake_Internal>c__Iterator0()
			{
			}

			// Token: 0x0600004F RID: 79 RVA: 0x00002220 File Offset: 0x00000420
			[Token(Token = "0x6001441")]
			[Address(RVA = "0xCAAA34", Offset = "0xCAAA34", VA = "0x6CAAA34", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x06000050 RID: 80 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170001A1")]
			private object Current
			{
				[Token(Token = "0x6001442")]
				[Address(RVA = "0xCABF30", Offset = "0xCABF30", VA = "0x6CABF30", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x06000051 RID: 81 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170001A2")]
			private object Current
			{
				[Token(Token = "0x6001443")]
				[Address(RVA = "0xCABF38", Offset = "0xCABF38", VA = "0x6CABF38", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06000052 RID: 82 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001444")]
			[Address(RVA = "0xCABF40", Offset = "0xCABF40", VA = "0x6CABF40", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			// Token: 0x06000053 RID: 83 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001445")]
			[Address(RVA = "0xCABF54", Offset = "0xCABF54", VA = "0x6CABF54", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			// Token: 0x04000029 RID: 41
			[Token(Token = "0x40012C2")]
			[FieldOffset(Offset = "0x8")]
			internal Vector3 seed;

			// Token: 0x0400002A RID: 42
			[Token(Token = "0x40012C3")]
			[FieldOffset(Offset = "0x14")]
			internal int <mod1>__0;

			// Token: 0x0400002B RID: 43
			[Token(Token = "0x40012C4")]
			[FieldOffset(Offset = "0x18")]
			internal int <mod2>__0;

			// Token: 0x0400002C RID: 44
			[Token(Token = "0x40012C5")]
			[FieldOffset(Offset = "0x1C")]
			internal int <mod3>__0;

			// Token: 0x0400002D RID: 45
			[Token(Token = "0x40012C6")]
			[FieldOffset(Offset = "0x20")]
			internal Camera cam;

			// Token: 0x0400002E RID: 46
			[Token(Token = "0x40012C7")]
			[FieldOffset(Offset = "0x24")]
			internal float <pixelWidth>__0;

			// Token: 0x0400002F RID: 47
			[Token(Token = "0x40012C8")]
			[FieldOffset(Offset = "0x28")]
			internal Transform <cachedTransform>__0;

			// Token: 0x04000030 RID: 48
			[Token(Token = "0x40012C9")]
			[FieldOffset(Offset = "0x2C")]
			internal int numberOfShakes;

			// Token: 0x04000031 RID: 49
			[Token(Token = "0x40012CA")]
			[FieldOffset(Offset = "0x30")]
			internal int <currentShakes>__0;

			// Token: 0x04000032 RID: 50
			[Token(Token = "0x40012CB")]
			[FieldOffset(Offset = "0x34")]
			internal float distance;

			// Token: 0x04000033 RID: 51
			[Token(Token = "0x40012CC")]
			[FieldOffset(Offset = "0x38")]
			internal float <shakeDistance>__0;

			// Token: 0x04000034 RID: 52
			[Token(Token = "0x40012CD")]
			[FieldOffset(Offset = "0x3C")]
			internal float <rotationStrength>__0;

			// Token: 0x04000035 RID: 53
			[Token(Token = "0x40012CE")]
			[FieldOffset(Offset = "0x40")]
			internal float <startTime>__0;

			// Token: 0x04000036 RID: 54
			[Token(Token = "0x40012CF")]
			[FieldOffset(Offset = "0x44")]
			internal bool multiplyByTimeScale;

			// Token: 0x04000037 RID: 55
			[Token(Token = "0x40012D0")]
			[FieldOffset(Offset = "0x48")]
			internal float <scale>__0;

			// Token: 0x04000038 RID: 56
			[Token(Token = "0x40012D1")]
			[FieldOffset(Offset = "0x4C")]
			internal float uiShakeModifier;

			// Token: 0x04000039 RID: 57
			[Token(Token = "0x40012D2")]
			[FieldOffset(Offset = "0x50")]
			internal float <pixelScale>__0;

			// Token: 0x0400003A RID: 58
			[Token(Token = "0x40012D3")]
			[FieldOffset(Offset = "0x54")]
			internal Vector3 <start1>__0;

			// Token: 0x0400003B RID: 59
			[Token(Token = "0x40012D4")]
			[FieldOffset(Offset = "0x60")]
			internal Quaternion <startR>__0;

			// Token: 0x0400003C RID: 60
			[Token(Token = "0x40012D5")]
			[FieldOffset(Offset = "0x70")]
			internal Vector2 <start2>__0;

			// Token: 0x0400003D RID: 61
			[Token(Token = "0x40012D6")]
			[FieldOffset(Offset = "0x78")]
			internal CameraShake.ShakeType shakeType;

			// Token: 0x0400003E RID: 62
			[Token(Token = "0x40012D7")]
			[FieldOffset(Offset = "0x7C")]
			internal CameraShake.ShakeState <state>__0;

			// Token: 0x0400003F RID: 63
			[Token(Token = "0x40012D8")]
			[FieldOffset(Offset = "0x80")]
			internal List<CameraShake.ShakeState> <stateList>__0;

			// Token: 0x04000040 RID: 64
			[Token(Token = "0x40012D9")]
			[FieldOffset(Offset = "0x84")]
			internal Vector3 rotationAmount;

			// Token: 0x04000041 RID: 65
			[Token(Token = "0x40012DA")]
			[FieldOffset(Offset = "0x90")]
			internal Vector3 shakeAmount;

			// Token: 0x04000042 RID: 66
			[Token(Token = "0x40012DB")]
			[FieldOffset(Offset = "0x9C")]
			internal float speed;

			// Token: 0x04000043 RID: 67
			[Token(Token = "0x40012DC")]
			[FieldOffset(Offset = "0xA0")]
			internal float <timer>__1;

			// Token: 0x04000044 RID: 68
			[Token(Token = "0x40012DD")]
			[FieldOffset(Offset = "0xA4")]
			internal Vector3 <camOffset>__1;

			// Token: 0x04000045 RID: 69
			[Token(Token = "0x40012DE")]
			[FieldOffset(Offset = "0xB0")]
			internal Quaternion <camRot>__1;

			// Token: 0x04000046 RID: 70
			[Token(Token = "0x40012DF")]
			[FieldOffset(Offset = "0xC0")]
			internal Vector3 <avg>__1;

			// Token: 0x04000047 RID: 71
			[Token(Token = "0x40012E0")]
			[FieldOffset(Offset = "0xCC")]
			internal float decay;

			// Token: 0x04000048 RID: 72
			[Token(Token = "0x40012E1")]
			[FieldOffset(Offset = "0xD0")]
			internal Action callback;

			// Token: 0x04000049 RID: 73
			[Token(Token = "0x40012E2")]
			[FieldOffset(Offset = "0xD4")]
			internal CameraShake $this;

			// Token: 0x0400004A RID: 74
			[Token(Token = "0x40012E3")]
			[FieldOffset(Offset = "0xD8")]
			internal object $current;

			// Token: 0x0400004B RID: 75
			[Token(Token = "0x40012E4")]
			[FieldOffset(Offset = "0xDC")]
			internal bool $disposing;

			// Token: 0x0400004C RID: 76
			[Token(Token = "0x40012E5")]
			[FieldOffset(Offset = "0xE0")]
			internal int $PC;
		}

		// Token: 0x02000007 RID: 7
		[Token(Token = "0x20002B6")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F5D0", Offset = "0x17F5D0")]
		private sealed class <DoResetState>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
		{
			// Token: 0x06000054 RID: 84 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001446")]
			[Address(RVA = "0xCA7C68", Offset = "0xCA7C68", VA = "0x6CA7C68")]
			[DebuggerHidden]
			public <DoResetState>c__Iterator1()
			{
			}

			// Token: 0x06000055 RID: 85 RVA: 0x00002238 File Offset: 0x00000438
			[Token(Token = "0x6001447")]
			[Address(RVA = "0xCA89DC", Offset = "0xCA89DC", VA = "0x6CA89DC", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x06000056 RID: 86 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170001A3")]
			private object Current
			{
				[Token(Token = "0x6001448")]
				[Address(RVA = "0xCAA988", Offset = "0xCAA988", VA = "0x6CAA988", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x06000057 RID: 87 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170001A4")]
			private object Current
			{
				[Token(Token = "0x6001449")]
				[Address(RVA = "0xCAA990", Offset = "0xCAA990", VA = "0x6CAA990", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06000058 RID: 88 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600144A")]
			[Address(RVA = "0xCAA998", Offset = "0xCAA998", VA = "0x6CAA998", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			// Token: 0x06000059 RID: 89 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600144B")]
			[Address(RVA = "0xCAA9AC", Offset = "0xCAA9AC", VA = "0x6CAA9AC", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			// Token: 0x0400004D RID: 77
			[Token(Token = "0x40012E6")]
			[FieldOffset(Offset = "0x8")]
			internal IList<Camera> cameras;

			// Token: 0x0400004E RID: 78
			[Token(Token = "0x40012E7")]
			[FieldOffset(Offset = "0xC")]
			internal IDictionary<Camera, int> shakeCount;

			// Token: 0x0400004F RID: 79
			[Token(Token = "0x40012E8")]
			[FieldOffset(Offset = "0x10")]
			internal float <t>__0;

			// Token: 0x04000050 RID: 80
			[Token(Token = "0x40012E9")]
			[FieldOffset(Offset = "0x14")]
			internal float <x>__0;

			// Token: 0x04000051 RID: 81
			[Token(Token = "0x40012EA")]
			[FieldOffset(Offset = "0x18")]
			internal float <y>__0;

			// Token: 0x04000052 RID: 82
			[Token(Token = "0x40012EB")]
			[FieldOffset(Offset = "0x1C")]
			internal float time;

			// Token: 0x04000053 RID: 83
			[Token(Token = "0x40012EC")]
			[FieldOffset(Offset = "0x20")]
			internal int <i>__1;

			// Token: 0x04000054 RID: 84
			[Token(Token = "0x40012ED")]
			[FieldOffset(Offset = "0x24")]
			internal CameraShake $this;

			// Token: 0x04000055 RID: 85
			[Token(Token = "0x40012EE")]
			[FieldOffset(Offset = "0x28")]
			internal object $current;

			// Token: 0x04000056 RID: 86
			[Token(Token = "0x40012EF")]
			[FieldOffset(Offset = "0x2C")]
			internal bool $disposing;

			// Token: 0x04000057 RID: 87
			[Token(Token = "0x40012F0")]
			[FieldOffset(Offset = "0x30")]
			internal int $PC;
		}
	}
}
