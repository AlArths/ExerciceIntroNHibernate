using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public interface IProspectRepository
    {
        /// <summary>
        /// Retuen all prospects
        /// </summary>
        /// <returns></returns>
        List<Prospect> GetAll();

        /// <summary>
        /// Save a prospect
        /// </summary>
        /// <param name="prospect">The prospect</param>
        void Save(Prospect prospect);
    }
}
