using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodreadsDoppelganger.Models
{
    public static class DbInitializer
    {
        public static void Seed(GoodreadsContext context)
        {
            if (!context.Authors.Any())
            {
                context.AddRange
                    (
                        new Author { FirstName = "Jeff", LastName = "Noon" },
                        new Author { FirstName = "Adrain", LastName = "Tchaikovsky" },
                        new Author { FirstName = "Ann", LastName = "Napolitano" }
                    );
            }

            context.SaveChanges();

            if (!context.Books.Any())
            {
                context.AddRange
                (
                    new Book { Title = "Within Without", AuthorId = 1, Rating = 4, Genre = "Fantasy", ImageUrl = "/images/WithinWithoutByJeffNoon.jpg", NumberOfPages = 373, PublicationDate = new DateTime(2021, 5, 21), Description = "From true weird fiction visionary Jeff Noon comes the fourth book in this Philip K. Dick Award-nominated mystery series, as private eye John Nyquist In the year 1960, rock and roll star Vince Craven hires private eye John Nyquist in his strangest case yet: to track down Vince's image, long lost in a city of million borders" },
                    new Book { Title = "The Doors Of Eden", AuthorId = 2, Rating = 5, Genre = "Fantasy", ImageUrl = "/images/TheDoorsOfEdenByAdrianTchaikovsky.jpg", NumberOfPages = 640, PublicationDate = new DateTime(2020, 10, 22), Description = "They thought we were safe. They were wrong. Four years ago, two girls went looking for monsters on Bodmin Moor. Only one came back. Lee thought she'd lost Mal, but now she's miraculously returned. But what happened that day on the moors? And where has she been all this time? Mal's reappearance hasn't gone unnoticed by MI5 officers either, and Lee isn't the only one with questions. Julian Sabreur is investigating an attack on top physicist Kay Amal Khan. This leads Julian to clash with agents of an unknown power - and they may or may not be human. His only clue is grainy footage, showing a woman who supposedly died on Bodmin Moor. Dr Khan's research was theoretical; then she found cracks between our world and parallel Earths. Now these cracks are widening, revealing extraordinary creatures. And as the doors crash open, anything could come through." },
                    new Book { Title = "Dear Edward", AuthorId = 3, Rating = 5, Genre = "Fantasy", NumberOfPages = 352, ImageUrl = "/images/DearEdwardByAnnNapolitano.jpg", PublicationDate = new DateTime(2020, 1, 6), Description = "What does it mean not just to survive, but to truly live? One summer morning, twelve-year-old Edward Adler, his beloved older brother, his parents, and 183 other passengers board a flight in Newark headed for Los Angeles. Among them are a Wall Street wunderkind, a young woman coming to terms with an unexpected pregnancy, an injured veteran returning from Afghanistan, a business tycoon, and a free - spirited woman running away from her controlling husband.Halfway across the country, the plane crashes.Edward is the sole survivor. Edward’s story captures the attention of the nation, but he struggles to find a place in a world without his family.He continues to feel that a part of himself has been left in the sky, forever tied to the plane and all of his fellow passengers.But then he makes an unexpected discovery—one that will lead him to the answers of some of life’s most profound questions: When you’ve lost everything, how do you find the strength to put one foot in front of the other? How do you learn to feel safe again? How do you find meaning in your life? Dear Edward is at once a transcendent coming - of - age story, a multidimensional portrait of an unforgettable cast of characters, and a breathtaking illustration of all the ways a broken heart learns to love again." }

                );
            }

            context.SaveChanges();
        }
    }
}
