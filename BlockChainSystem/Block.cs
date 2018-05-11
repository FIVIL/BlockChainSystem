using System;
using System.Collections.Generic;
using System.Text;
using CryptoApi;
using TransactionManager;
using Blake2Sharp;
using System.Linq;

namespace BlockChainSystem
{
    class Block
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid ID { get; private set; }
        public string BlockName { get; set; }
        public uint Height { get; private set; }
        public uint Version { get; private set; }
        public BlockVersionPrinciples VersionPrinciples { get; private set; }
        public string HashString { get; private set; }
        public string PrevHash { get; private set; }
        public string NextHash { get; set; }
        public string MerkleRoot { get; private set; }
        /// <summary>
        /// For immportant things.
        /// </summary>
        public string BlockData { get; private set; }
        /// <summary>
        /// for any thing
        /// </summary>
        public string BlcokMetadata { get; set; }
        public string MinerPublicKey { get; private set; }
        public List<Transaction> Transactions { get; private set; }
        public double TotalOutput { get => Transactions.Sum(x => x.Amount); }
        public DateTime TimeStamp { get; private set; }
        public DateTime MiningTime { get; set; }
        public uint Nonce { get; private set; }
        #region ctor
        public Block()
        {

        }
        #endregion
    }
}
