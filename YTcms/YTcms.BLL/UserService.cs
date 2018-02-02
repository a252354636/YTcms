using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YTcms.EF.Model;
using YTcms.IBLL;
using YTcms.IDAL;


namespace YTcms.BLL
{
    public partial class UsersService : BaseService<dt_users>, IUsersService
    {
        private IUsersDAL UsersDAL = DALContainer.Container.Resolve<IUsersDAL>();
        public override void SetDal()
        {
            Dal = UsersDAL;
        }
    }
}
