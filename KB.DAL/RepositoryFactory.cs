using System;
using KB.IDAL;
using KB.Models;

namespace KB.DAL
{
    /// <summary>
    /// 简单工厂
    /// </summary>
    public static class RepositoryFactory
    {
       

        /// <summary>
        /// 消费仓储
        /// </summary>
        public static InterfaceSpendTextRepository SpendTextRepository { get { return new SpendTextRepository(); } }

        /// <summary>
        /// 客户仓储
        /// </summary>
        public static InterfaceAdminRepository AdminRepository { get { return new AdminRepository(); } }


        /// <summary>
        /// 游戏仓储
        /// </summary>
        public static InterfaceGameRepository GameRepository { get { return new GameRepository(); } }

        /// <summary>
        /// Root管理仓储
        /// </summary>
        public static InterfaceRootRepository RootRepository { get { return new RootRepository(); } }
        /// <summary>
        ///过币仓储
        /// </summary>
        public static InterfaceTransferRepository TransferRepository { get { return new TransferRepository(); } }

        /// <summary>
        /// 用户仓储
        /// </summary>
        public static InterfaceUserRepository UserRepository { get { return new UserRepository(); } }
        /// <summary>
        /// 用户仓储
        /// </summary>
        public static InterfaceEditCentRepository EditCentRepository { get { return new EditCentRepository(); } }
        /// <summary>
        /// 酷酷快玩开奖号码仓储
        /// </summary>
        public static InterfaceKkkwNumRepository KkkwNumRepository { get { return new KkkwNumRepository(); } }
        /// <summary>
        /// 酷酷快玩订单仓储
        /// </summary>
        public static InterfaceKkkwOrderRepository KkkwOrderRepository { get { return new KkkwOrderRepository(); } }
        /// <summary>
        /// 酷酷快玩设置仓储
        /// </summary>
        public static InterfaceKkkwSetRepository KkkwSetRepository { get { return new KkkwSetRepository(); } }
    }
}
