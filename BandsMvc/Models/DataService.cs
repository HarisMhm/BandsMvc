namespace BandsMvc.Models
{
    public class DataService
    {

        List<Band> bands = new List<Band>
        {
            // Fejk-DB            
            new Band { Id = 20, Name = "AC/DC", Description = "Hårdrocksband"},
            new Band { Id = 25, Name = "ABBA", Description = "Kanobra musik"},
            new Band { Id = 27, Name = "Metallica", Description = "Metal"},
        };

        public Band GetBandById(int id)
        {
            return bands
                .FirstOrDefault(i => i.Id == id);
        }
        public Band[] GetAll()
        {
            return bands
                .ToArray();
        }

    }
}
