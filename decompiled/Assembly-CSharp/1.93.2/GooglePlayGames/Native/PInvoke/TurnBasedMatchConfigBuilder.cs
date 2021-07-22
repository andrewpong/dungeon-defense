using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x02000217 RID: 535
	[Token(Token = "0x200018F")]
	internal class TurnBasedMatchConfigBuilder : BaseReferenceHolder
	{
		// Token: 0x06000E34 RID: 3636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CE6")]
		[Address(RVA = "0x48BAA8", Offset = "0x48BAA8", VA = "0x648BAA8")]
		private TurnBasedMatchConfigBuilder(IntPtr selfPointer)
		{
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000CE7")]
		[Address(RVA = "0x48BB34", Offset = "0x48BB34", VA = "0x648BB34")]
		internal TurnBasedMatchConfigBuilder PopulateFromUIResponse(PlayerSelectUIResponse response)
		{
			return null;
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000CE8")]
		[Address(RVA = "0x48BB90", Offset = "0x48BB90", VA = "0x648BB90")]
		internal TurnBasedMatchConfigBuilder SetVariant(uint variant)
		{
			return null;
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000CE9")]
		[Address(RVA = "0x48BBD0", Offset = "0x48BBD0", VA = "0x648BBD0")]
		internal TurnBasedMatchConfigBuilder AddInvitedPlayer(string playerId)
		{
			return null;
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000CEA")]
		[Address(RVA = "0x48BC10", Offset = "0x48BC10", VA = "0x648BC10")]
		internal TurnBasedMatchConfigBuilder SetExclusiveBitMask(ulong bitmask)
		{
			return null;
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000CEB")]
		[Address(RVA = "0x48BC60", Offset = "0x48BC60", VA = "0x648BC60")]
		internal TurnBasedMatchConfigBuilder SetMinimumAutomatchingPlayers(uint minimum)
		{
			return null;
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000CEC")]
		[Address(RVA = "0x48BCA0", Offset = "0x48BCA0", VA = "0x648BCA0")]
		internal TurnBasedMatchConfigBuilder SetMaximumAutomatchingPlayers(uint maximum)
		{
			return null;
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000CED")]
		[Address(RVA = "0x48BCE0", Offset = "0x48BCE0", VA = "0x648BCE0")]
		internal TurnBasedMatchConfig Build()
		{
			return null;
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CEE")]
		[Address(RVA = "0x48BD78", Offset = "0x48BD78", VA = "0x648BD78", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000CEF")]
		[Address(RVA = "0x48BD88", Offset = "0x48BD88", VA = "0x648BD88")]
		internal static TurnBasedMatchConfigBuilder Create()
		{
			return null;
		}
	}
}
