namespace BandsMvc.Models
{
    public class DataService
    {

        List<Band> bands = new List<Band>
        {
            // Fejk-DB            
            new Band { Id = 1, Name = "AC/DC", Description = "Hårdrocksband"},
            new Band { Id = 2, Name = "ABBA", Description = "Kanobra musik"},
            new Band { Id = 3, Name = "Metallica", Description = "Metal"},
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
