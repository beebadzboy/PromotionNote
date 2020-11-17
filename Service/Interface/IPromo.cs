using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Service.Interface
{
    public interface IPromo
    {
        List<ProHeaderViewModel> GetProList();

        void SaveProList(ProHeaderInputModel input);

        void UpdateProList(ProHeaderInputModel input);

        void DeleteProList(ProHeaderInputModel input);
    }
}
