using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Contrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Container
{
    // ninjectmodule olduğu için kalıtım yaptık.
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            
            Bind<IServiceService>().To<ServiceManager>().InSingletonScope();
            Bind<IServicesDal>().To<EfServicesDal>().InSingletonScope();

            Bind<IAboutService>().To<AboutManager>().InSingletonScope();
            Bind<IAboutDal>().To<EfAboutDal>().InSingletonScope();

            Bind<IAdminService>().To<AdminManager>().InSingletonScope();
            Bind<IAdminDal>().To<EfAdminDal>().InSingletonScope();

            Bind<IAddressService>().To<AddressManager>().InSingletonScope();
            Bind<IAddressDal>().To<EfAddressDal>().InSingletonScope();

            Bind<IAttentionService>().To<AttentionManager>().InSingletonScope();
            Bind<IAttentionDal>().To<EfAttentionDal>().InSingletonScope();

            Bind<IContactService>().To<ContactManager>().InSingletonScope();
            Bind<IContactDal>().To<EfContactDal>().InSingletonScope();

            Bind<IımageService>().To<ImageManager>().InSingletonScope();
            Bind<IImageDal>().To<EfImageDal>().InSingletonScope();

            Bind<INewService>().To<NewsManager>().InSingletonScope();
            Bind<INewsDal>().To<EfNewsDal>().InSingletonScope();

            Bind<IRecentProjectService>().To<RecentProjectManager>().InSingletonScope();
            Bind<IRecentProjectDal>().To<EfRecentProjectDal>().InSingletonScope();

            Bind<ISocialMediaService>().To<SocialMediaManager>().InSingletonScope();
            Bind<ISocialMediaDal>().To<EfSocialMediaDal>().InSingletonScope();

            Bind<ITeamService>().To<TeamManager>().InSingletonScope();
            Bind<ITeamDal>().To<EfTeamDal>().InSingletonScope();

            


        }
    }
}
