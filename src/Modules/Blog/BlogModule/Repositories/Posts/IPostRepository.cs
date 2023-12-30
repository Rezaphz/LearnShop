using BlogModule.Context;
using BlogModule.Domain;
using Common.Domain.Repository;
using Common.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogModule.Repositories.Posts
{
     interface IPostRepository : IBaseRepository<Post>
    {
    }

    class PostRepository : BaseRepository<Post, BlogContext>, IPostRepository
    {
        public PostRepository(BlogContext context) : base(context)
        {
        }
    }
}
