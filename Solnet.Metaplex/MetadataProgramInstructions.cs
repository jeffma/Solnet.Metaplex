using System.Collections.Generic;

namespace Solnet.Metaplex
{
    internal static class MetadataProgramInstructions
    {
        /// <summary>
        /// Represents the user-friendly names for the instruction types for the <see cref="MetadataProgram"/>.
        /// </summary>
        internal static readonly Dictionary<Values, string> Names = new()
        {
            { Values.CreateMetadataAccount, "Create MetadataAccount" },
            { Values.UpdateMetadataAccount, "Update MetadataAccount" },
            { Values.DeprecatedCreateMasterEdition, "Create MasterEdition (deprecated) " },
            { Values.DeprecatedMintNewEditionFromMasterEditionViaPrintingToken, "Mint new Edition from MasterEdition via PrintingToken (deprecated)" },
            { Values.UpdatePrimarySaleHappenedViaToken, "Update PrimarySaleHappened" },
            { Values.DeprecatedSetReservationList, "Set ReservationList (deprecated)" },
            { Values.DeprecatedCreateReservationList, "Create Reservation List (deprecated)" },
            { Values.SignMetadata, "Sign Metadata" },
            { Values.DeprecatedMintPrintingTokensViaToken, "Mint PrintingTokens via token (deprecated)" },
            { Values.DeprecatedMintPrintingTokens, "Mint PrintingTokens (deprecated)" },
            { Values.CreateMasterEdition, "Create MasterEdition" },
            { Values.MintNewEditionFromMasterEditionViaToken, "Mint new Edition from MasterEdition via token" },
            { Values.ConvertMasterEditionV1ToV2, "Convert Master Edition from V1 to V2" },
            { Values.MintNewEditionFromMasterEditionViaVaultProxy, "Mint new Edition from MasterEdition via VaultProxy" },
            { Values.PuffMetadata, "Puff metadata" },
            { Values.UpdateMetadataAccountV2, "Update a Metadata with is_mutable as a parameter" },
            { Values.CreateMetadataAccountV2, "Create V2 MetadataAccount." },
            { Values.CreateMasterEditionV3, "Register a Metadata as a Master Edition V3" },
            { Values.VerifyCollection, "Verify the NFT Belongs in the Collection." },
            { Values.Utilize, "Utilize an NFT" },
            { Values.ApproveUseAuthority , "Approve another account to call [utilize] on this NFT." },
            { Values.RevokeUseAuthority, "Revoke account to call [utilize] on this NFT." },
            { Values.UnverifyCollection, "Unverify an NFT in a collection." },
            { Values.ApproveCollectionAuthority , "Approve another account to verify NFTs belonging to a collection." },
            { Values.RevokeCollectionAuthority, "Revoke account to call [verify_collection] on this NFT." },
            { Values.SetAndVerifyCollection , "perform [update_metadata_accounts_v2] and [verify_collection] in one instruction." },
            { Values.FreezeDelegatedAccount, "Allow freezing of an NFT if this user is the delegate of the NFT." },
            { Values.ThawDelegatedAccount , "Allow thawing of an NFT if this user is the delegate of the NFT." },
            { Values.RemoveCreatorVerification, "Remove Creator Verificaton." },
            { Values.BurnNft, "Completely burn a NFT, including closing the metadata account." },
            { Values.VerifySizedCollectionItem, "Verify Collection V2, new in v1.3--supports Collection Details." },
            { Values.UnverifySizedCollectionItem, "Unverify Collection V2, new in v1.3--supports Collection Details." },
            { Values.SetAndVerifySizedCollectionItem, "Set And Verify V2, new in v1.3--supports Collection Details." },
            { Values.CreateMetadataAccountV3, "Create Metadata V3 object." },
            { Values.SetCollectionSize, "Set size of an existing collection." },
            { Values.SetTokenStandard, "Set the token standard of the asset." }

        };

        /// <summary>
        /// Represents the instruction types for the <see cref="MetadataProgram"/>.
        /// </summary>
        internal enum Values : byte
        {
            /// <summary>
            /// 
            /// </summary>
            CreateMetadataAccount = 0,

            /// <summary>
            /// 
            /// </summary>
            UpdateMetadataAccount = 1,

            /// <summary>
            ///
            /// </summary>
            DeprecatedCreateMasterEdition = 2,

            /// <summary>
            /// 
            /// </summary>
            DeprecatedMintNewEditionFromMasterEditionViaPrintingToken = 3,

            /// <summary>
            /// 
            /// </summary>
            UpdatePrimarySaleHappenedViaToken = 4,

            /// <summary>
            /// 
            /// </summary>
            DeprecatedSetReservationList = 5,

            /// <summary>
            /// 
            /// </summary>
            DeprecatedCreateReservationList = 6,

            /// <summary>
            /// 
            /// </summary>
            SignMetadata = 7,

            /// <summary>
            /// 
            /// </summary>
            DeprecatedMintPrintingTokensViaToken = 8,
            /// <summary>
            /// 
            /// </summary>
            DeprecatedMintPrintingTokens = 9,

            /// <summary>
            /// 
            /// </summary>
            CreateMasterEdition = 10,

            /// <summary>
            /// 
            /// </summary>
            MintNewEditionFromMasterEditionViaToken = 11,

            /// <summary>
            /// 
            /// </summary>
            ConvertMasterEditionV1ToV2 = 12,

            /// <summary>
            /// 
            /// </summary>
            MintNewEditionFromMasterEditionViaVaultProxy = 13,

            /// <summary>
            /// 
            /// </summary>
            PuffMetadata = 14,
            /// <summary>
            /// 
            /// </summary>
            UpdateMetadataAccountV2 = 15,
            /// <summary>
            /// 
            /// </summary>
            CreateMetadataAccountV2 = 16,
            /// <summary>
            /// 
            /// </summary>
            CreateMasterEditionV3 = 17,
            /// <summary>
            /// 
            /// </summary>
            VerifyCollection = 18,
            /// <summary>
            /// 
            /// </summary>
            Utilize = 19,
            /// <summary>
            /// 
            /// </summary>
            ApproveUseAuthority = 20,
            /// <summary>
            /// 
            /// </summary>
            RevokeUseAuthority = 21,
            /// <summary>
            /// 
            /// </summary>
            UnverifyCollection = 22,
            /// <summary>
            /// 
            /// </summary>
            ApproveCollectionAuthority = 23,
            /// <summary>
            /// 
            /// </summary>
            RevokeCollectionAuthority = 24,
            /// <summary>
            /// 
            /// </summary>
            SetAndVerifyCollection = 25,
            /// <summary>
            /// 
            /// </summary>
            FreezeDelegatedAccount = 26,
            /// <summary>
            /// 
            /// </summary>
            ThawDelegatedAccount = 27,
            /// <summary>
            /// 
            /// </summary>
            RemoveCreatorVerification = 28,
            /// <summary>
            /// 
            /// </summary>
            BurnNft = 29,
            /// <summary>
            /// 
            /// </summary>
            VerifySizedCollectionItem = 30,
            /// <summary>
            /// 
            /// </summary>
            UnverifySizedCollectionItem = 31,
            /// <summary>
            /// 
            /// </summary>
            SetAndVerifySizedCollectionItem = 32,
            /// <summary>
            /// 
            /// </summary>
            CreateMetadataAccountV3 = 33,
            /// <summary>
            /// 
            /// </summary>
            SetCollectionSize = 34,
            /// <summary>
            /// 
            /// </summary>
            SetTokenStandard = 35
        }
    }
}