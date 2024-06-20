using TheMamboBros.Data.Context;
using TheMamboBros.Data.Entities;
using TheMamboBros.Data.Interfaces;

namespace TheMamboBros.Data.DAO
{
    public class DaoMusic : DaoBase<Music>, IDaoMusic
    {
        public DaoMusic(TheMamboBrosContext dbContext) : base(dbContext)
        {
        }
    }
}
