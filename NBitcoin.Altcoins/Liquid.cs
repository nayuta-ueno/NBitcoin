using System;
using System.Reflection;
using System.Collections.Generic;
using System.Text;
using NBitcoin.Altcoins.Elements;
using NBitcoin.DataEncoders;
using Encoders = NBitcoin.DataEncoders.Encoders;

namespace NBitcoin.Altcoins
{
	public class Liquid : NetworkSetBase
	{
		public class LiquidRegtest { }
		static Liquid()
		{
			ElementsParams<Liquid>.PeggedAssetId = new uint256("6f0279e9ed041c3d710a9f57d0c02928416460c4b722ae3457a11eec381c526d");
			ElementsParams<Liquid>.SignedBlocks = true;
			ElementsParams<Liquid>.BlockHeightInHeader = true;
			ElementsParams<LiquidRegtest>.PeggedAssetId = new uint256("e92abec3915196b0858900ddc754107326fc597dfdf8975412d4d5e290e92057");
			ElementsParams<LiquidRegtest>.SignedBlocks = true;
			ElementsParams<LiquidRegtest>.BlockHeightInHeader = true;

		}
		public override string CryptoCode => "LBTC";
		public static Liquid Instance { get; } = new Liquid();

		protected override NetworkBuilder CreateMainnet()
		{
			var builder = new NetworkBuilder();
			builder.SetConsensus(new Consensus()
			{
				SubsidyHalvingInterval = 150,
				MajorityEnforceBlockUpgrade = 51,
				MajorityRejectBlockOutdated = 75,
				MajorityWindow = 144,
				PowLimit = new Target(new uint256("7fffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff")),
				PowTargetTimespan = TimeSpan.FromSeconds(14 * 24 * 60 * 60),
				PowTargetSpacing = TimeSpan.FromSeconds(1 * 60),
				PowAllowMinDifficultyBlocks = true,
				MinimumChainWork = uint256.Zero,
				PowNoRetargeting = true,
				RuleChangeActivationThreshold = 108,
				MinerConfirmationWindow = 144,
				CoinbaseMaturity = 100,
				ConsensusFactory = ElementsConsensusFactory<Liquid>.Instance
			})
			.SetNetworkStringParser(new ElementsStringParser())
			.SetBase58Bytes(Base58Type.PUBKEY_ADDRESS, new byte[] { (57) })
			.SetBase58Bytes(Base58Type.SCRIPT_ADDRESS, new byte[] { (39) })
			.SetBase58Bytes(Base58Type.SECRET_KEY, new byte[] { (128) })
			.SetBase58Bytes(Base58Type.EXT_PUBLIC_KEY, new byte[] { (0x04), (0x88), (0xB2), (0x1E) })
			.SetBase58Bytes(Base58Type.EXT_SECRET_KEY, new byte[] { (0x04), (0x88), (0xAD), (0xE4) })
			.SetBase58Bytes(Base58Type.BLINDED_ADDRESS, new byte[] { 12 })
			.SetBech32(Bech32Type.WITNESS_PUBKEY_ADDRESS, Encoders.Bech32("ex"))
			.SetBech32(Bech32Type.WITNESS_SCRIPT_ADDRESS, Encoders.Bech32("ex"))
			.SetBech32(Bech32Type.BLINDED_ADDRESS, NBitcoin.Altcoins.Elements.ElementsEncoders.Blech32("lq"))
			.SetMagic(0xdab5bffa)
			.SetPort(7042)
			.SetRPCPort(7041)
			.SetName("liquid")
			.AddAlias("liquid-mainnet")
			.AddAlias("liquid-main")
			.SetGenesis("010000000000000000000000000000000000000000000000000000000000000000000000d767f204777d8ebd0825f4f26c3d773c0d3f40268dc6afb3632a0fcbd49fde45dae5494d00000000fd01025b21026a2a106ec32c8a1e8052e5d02a7b0a150423dbd9b116fc48d46630ff6e6a05b92102791646a8b49c2740352b4495c118d876347bf47d0551c01c4332fdc2df526f1a2102888bda53a424466b0451627df22090143bbf7c060e9eacb1e38426f6b07f2ae12102aee8967150dee220f613de3b239320355a498808084a93eaf39a34dcd62024852102d46e9259d0a0bb2bcbc461a3e68f34adca27b8d08fbe985853992b4b104e27412102e9944e35e5750ab621e098145b8e6cf373c273b7c04747d1aa020be0af40ccd62102f9a9d4b10a6d6c56d8c955c547330c589bb45e774551d46d415e51cd9ad5116321033b421566c124dfde4db9defe4084b7aa4e7f36744758d92806b8f72c2e943309210353dcc6b4cf6ad28aceb7f7b2db92a4bf07ac42d357adf756f3eca790664314b621037f55980af0455e4fb55aad9b85a55068bb6dc4740ea87276dc693f4598db45fa210384001daa88dabd23db878dbb1ce5b4c2a5fa72c3113e3514bf602325d0c37b8e21039056d089f2fe72dbc0a14780b4635b0dc8a1b40b7a59106325dd1bc45cc70493210397ab8ea7b0bf85bc7fc56bb27bf85e75502e94e76a6781c409f3f2ec3d1122192103b00e3b5b77884bf3cae204c4b4eac003601da75f96982ffcb3dcb29c5ee419b92103c1f3c0874cfe34b8131af34699589aacec4093399739ae352e8a46f80a6f68375fae00010100000000010000000000000000000000000000000000000000000000000000000000000000ffffffff2120961454ea0955421873d61bab197d814b3386fde2433c90bc1621ca1ef5462fc2ffffffff0101000000000000000000000000000000000000000000000000000000000000000001000000000000000000016a00000000");
			return builder;
		}

		protected override NetworkBuilder CreateTestnet()
		{
			return null;
		}

		protected override NetworkBuilder CreateRegtest()
		{
			var builder = new NetworkBuilder();
			builder.SetConsensus(new Consensus()
			{
				SubsidyHalvingInterval = 150,
				MajorityEnforceBlockUpgrade = 51,
				MajorityRejectBlockOutdated = 75,
				MajorityWindow = 144,
				PowLimit = new Target(new uint256("7fffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff")),
				PowTargetTimespan = TimeSpan.FromSeconds(3.5 * 24 * 60 * 60),
				PowTargetSpacing = TimeSpan.FromSeconds(10 * 60),
				PowAllowMinDifficultyBlocks = true,
				MinimumChainWork = uint256.Zero,
				PowNoRetargeting = true,
				RuleChangeActivationThreshold = 108,
				MinerConfirmationWindow = 2016,
				CoinbaseMaturity = 100,
				LitecoinWorkCalculation = true,
				ConsensusFactory = ElementsConsensusFactory<LiquidRegtest>.Instance
			})
			.SetNetworkStringParser(new ElementsStringParser())
			.SetBase58Bytes(Base58Type.PUBKEY_ADDRESS, new byte[] { (235) })
			.SetBase58Bytes(Base58Type.SCRIPT_ADDRESS, new byte[] { (75) })
			.SetBase58Bytes(Base58Type.SECRET_KEY, new byte[] { (239) })
			.SetBase58Bytes(Base58Type.EXT_PUBLIC_KEY, new byte[] { (0x04), (0x35), (0x87), (0xCF) })
			.SetBase58Bytes(Base58Type.EXT_SECRET_KEY, new byte[] { (0x04), (0x35), (0x83), (0x94) })
			.SetBase58Bytes(Base58Type.BLINDED_ADDRESS, new byte[] { 4 })
			.SetBech32(Bech32Type.WITNESS_PUBKEY_ADDRESS, Encoders.Bech32("ert"))
			.SetBech32(Bech32Type.WITNESS_SCRIPT_ADDRESS, Encoders.Bech32("ert"))
			.SetBech32(Bech32Type.BLINDED_ADDRESS, NBitcoin.Altcoins.Elements.ElementsEncoders.Blech32("el"))
			.SetMagic(0xdab5bffa)
			.SetPort(19444)
			.SetRPCPort(19332)
			.SetName("liq-reg")
			.AddAlias("liq-regtest")
			.AddAlias("liquid-reg")
			.AddAlias("liquid-regtest")
			.AddAlias("liquidregtest")
			//.SetGenesis("0100000000000000000000000000000000000000000000000000000000000000000000007d66aaa9b083d92a8597a47f4ede112743395c5f9036cc7192cc5737a39f37b3dae5494d00000000015100020100000000010000000000000000000000000000000000000000000000000000000000000000ffffffff212078fdfddeafc3bac34abe63efee0d64f7d817cee508ded08746ba4ae6df5349cbffffffff0101000000000000000000000000000000000000000000000000000000000000000001000000000000000000016a0000000001000000000178fdfddeafc3bac34abe63efee0d64f7d817cee508ded08746ba4ae6df5349cb0000008000ffffffff000000000000000000000000000000000000000000000000000000000000000006226e46111a0b59caaf126043eb5bbf28c34f3a5e332a1fc7b2b73cf188910f010000befe6f6720000100000000000000000101230f4f5d4b7c6fa845806ee4f67713459e1b69e8e60fcee2e4940c7a0d5de1b2010000befe6f67200000015100000000");
			.SetGenesis("01000000000000000000000000000000000000000000000000000000000000000000000091b8ea44bca3ceade46af55e20575c241f3bb28aa627a5e5641aeb30a622e24cdae5494d0000000025512103cd2aec5b56467a2f7479015218649b143dd94df311eb2415ac89d9e1b201efa751ae00020100000000010000000000000000000000000000000000000000000000000000000000000000ffffffff2120c4ecc0d4c6034b104f1dde4d6c812537bc86d36e36ddfe5a53e989df9e24a6b4ffffffff0101000000000000000000000000000000000000000000000000000000000000000001000000000000000000016a00000000010000000001c4ecc0d4c6034b104f1dde4d6c812537bc86d36e36ddfe5a53e989df9e24a6b40000008000ffffffff000000000000000000000000000000000000000000000000000000000000000006226e46111a0b59caaf126043eb5bbf28c34f3a5e332a1fc7b2b73cf188910f01000775f05a07400001000000000000000001015720e990e2d5d4125497f8fd7d59fc26731054c7dd008985b0965191c3be2ae901000775f05a07400000015100000000");
			return builder;
		}

		protected override void PostInit()
		{
			RegisterDefaultCookiePath("Liquid", new FolderName() { RegtestFolder = "liquidregtest", MainnetFolder = "liquidv1" });
		}
	}
}
