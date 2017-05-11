using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevCamp.Raffle.Models;

namespace DevCamp.Raffle.Services
{
    public class ParticipantsService : IParticipantsService
    {
        public async Task<IEnumerable<Participant>> GetAll()
        {
            await Task.Delay(TimeSpan.FromSeconds(3));
            return new List<Participant>
            {
                new Participant(1, "Benjamin  Anhalt", "Metamorph GmbH"),
                new Participant(4, "Martin Beck", "Profihost AG"),
                new Participant(2, "Georg  Dittrich", "Metamorph GmbH"),
                new Participant(28, "Björn  Drude", "Versand- und DatenService (VDS)"),
                new Participant(32, "Konstantin Dudel", "HHV Handels GmbH"),
                new Participant(26, "Juan (Nacho) Encinar", "7Bullets GmbH / Off Price GmbH"),
                new Participant(23, "Sven  Gösling", "7Bullets GmbH / Off Price GmbH"),
                new Participant(5, "Dennis  Heidtmann", "koffer-direkt.de GmbH & Co. KG"),
                new Participant(19, "André Herrmann", "FATCHIP GmbH"),
                new Participant(21, "Benjamin  Hornberg", "7Bullets GmbH / Off Price GmbH"),
                new Participant(11, "Joscha Krug", "ScaleCommerce GmbH"),
                new Participant(22, "Dennis  Lahmer", "7Bullets GmbH / Off Price GmbH"),
                new Participant(10, "Beuck Matthias", "Lederzentrum GmbH"),
                new Participant(8, "Veit  Möhlis", "Shopboost GmbH"),
                new Participant(20, "Jens  Opitz", "MS Autoteile"),
                new Participant(18, "Wolfgang Petsch", "Livario GmbH"),
                new Participant(16, "Michael  Pudenz", "geschenke-online.de (ggo)"),
                new Participant(17, "Alexander  Raabe", "Livario GmbH"),
                new Participant(3, "Jens Richter", "Heidelberger Payment"),
                new Participant(24, "Sebastian Ritter", "7Bullets GmbH / Off Price GmbH"),
                new Participant(6, "Martin  Scheffler", "Shopboost GmbH"),
                new Participant(7, "Jens Schindler", "Shopboost GmbH"),
                new Participant(31, "Alexander  Schlotthauer", "DEL-KO GmbH"),
                new Participant(14, "David  Schneider", "Holger Genkinger GmbH - Bettwaren-Shop.de"),
                new Participant(33, "Marcus Sprenger", "HHV Handels GmbH"),
                new Participant(9, "David Szczudlo", "Rhinos Media UG"),
                new Participant(30, "Sascha Toll", "Paian IT Solutions GmbH"),
                new Participant(25, "Markus  Vincke", "7Bullets GmbH / Off Price GmbH"),
                new Participant(15, "Sebastian Waldhelm", "geschenke-online.de (ggo)"),
                new Participant(27, "Martin  Weckwerth", "Versand- und DatenService (VDS)"),
                new Participant(12, "Udo Wessiepe ", "Stretta Music GmbH"),
                new Participant(13, "Philipp Wessiepe ", "Stretta Music GmbH"),
                new Participant(29, "Sven  Wittfoth", "Versand- und DatenService (VDS)"),

            };
        }
    }
}
