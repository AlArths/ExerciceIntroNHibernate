using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class StubProspectRepository : IProspectRepository
    {
        private List<Prospect> _prospects;

        public StubProspectRepository()
        {
            _prospects = new List<Prospect>();
            _prospects.Add(new Prospect("Dupond", "Jacques", "jacques@dupond.com", DateTime.Now, "Rappel urgent"));
            _prospects.Add(new Prospect("Leblanc", "Jean", "jean@leblanc.com", DateTime.Now));
            _prospects.Add(new Prospect("Martin", "Matt", "matt@martin.com", DateTime.Now));
        }

        public List<Prospect> GetAll()
        {
            return _prospects;
        }

        public void Save(Prospect prospect)
        {
            _prospects.Add(prospect);
        }
    }
}
