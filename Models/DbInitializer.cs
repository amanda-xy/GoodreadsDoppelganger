using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodreadsDoppelganger.Models
{
    public static class DbInitializer
    {
        public static void Seed(IServiceProvider serviceProvider)
        {
            using (var context = new GoodreadsContext(serviceProvider.GetRequiredService<DbContextOptions<GoodreadsContext>>()))
            {
                context.Database.Migrate();
                if (!context.Authors.Any())
                {
                    context.AddRange
                        (
                            new Author { FirstName = "Jeff", LastName = "Noon", BirthDate = new DateTime(1940, 2, 14), Biography = "Jeff Noon is a novelist, short story writer and playwright whose works make extensive use of wordplay and fantasy. He studied fine art and drama at Manchester University and was subsequently appointed writer in residence at the city's Royal Exchange theatre. But Noon did not stay too long in the theatrical world, possibly because the realism associated with the theatre was not conducive to the fantastical worlds he was itching to invent. While working behind the counter at the local Waterstone's bookshop,´a colleague suggested he write a novel.The result of that suggestion, Vurt, was the hippest sci - fi novel to be published in Britain since the days of Michael Moorcock in the late sixties."  },
                            new Author { FirstName = "Adrian", LastName = "Tchaikovsky", BirthDate = new DateTime(1952, 6, 2), Biography = "Adrian Tchaikovsky is a British novel writer who writes in the science fiction fantasy genre. Born Adrian CzajkowsKi in Woodhall Spa, Lincolnshire, Tchaikovsky went on to study Psychology and Zoology at the University of Reading. He later undertook legal studies and is currently a Legal Executive with the Leeds based Commercial Dispute Department of Black Solicitors." },
                            new Author { FirstName = "Ann", LastName = "Napolitano", BirthDate = new DateTime(1947, 11, 24), Biography= "Ann Napolitano’s new novel, Dear Edward, was published by Dial Press in January 2020 and was an instant New York Times bestseller. She is the author of the novels A Good Hard Look and Within Arm’s Reach. She was the Associate Editor of One Story literary magazine from 2014-2020. She received an MFA from New York University; she has taught fiction writing for Brooklyn College’s MFA program, New York University’s School of Continuing and Professional Studies and for Gotham Writers’ Workshop. In November 2019, Ann was long-listed for the Simpson/Joyce Carol Oates Literary Prize." },
                            new Author { FirstName = "Heather", LastName = "Morris", BirthDate = new DateTime(1973, 5, 30), Biography = "Heather Morris is a native of New Zealand, now resident in Australia. For several years, while working in a large public hospital in Melbourne, she studied and wrote screenplays, one of which was optioned by an Academy Award-winning screenwriter in the US. In 2003, Heather was introduced to an elderly gentleman who ‘might just have a story worth telling’. The day she met Lale Sokolov changed both their lives. Their friendship grew and Lale embarked on a journey of self-scrutiny, entrusting the innermost details of his life during the Holocaust to her. Heather originally wrote Lale’s story as a screenplay – which ranked high in international competitions – before reshaping it into her debut novel, The Tattooist of Auschwitz" }
                        );
                }

                context.SaveChanges();

                if (!context.Books.Any())
                {
                    context.AddRange
                    (
                        new Book { Title = "Within Without", AuthorId = 1, Genre = Genre.Fantasy, ImageUrl = "/images/WithinWithoutByJeffNoon.jpg", NumberOfPages = 373, PublicationDate = new DateTime(2021, 5, 21), Description = "From true weird fiction visionary Jeff Noon comes the fourth book in this Philip K. Dick Award-nominated mystery series, as private eye John Nyquist In the year 1960, rock and roll star Vince Craven hires private eye John Nyquist in his strangest case yet: to track down Vince's image, long lost in a city of million borders" },
                        new Book { Title = "The Doors Of Eden", AuthorId = 2, Genre = Genre.Fantasy, ImageUrl = "/images/TheDoorsOfEdenByAdrianTchaikovsky.jpg", NumberOfPages = 640, PublicationDate = new DateTime(2020, 10, 22), Description = "They thought we were safe. They were wrong. Four years ago, two girls went looking for monsters on Bodmin Moor. Only one came back. Lee thought she'd lost Mal, but now she's miraculously returned. But what happened that day on the moors? And where has she been all this time? Mal's reappearance hasn't gone unnoticed by MI5 officers either, and Lee isn't the only one with questions. Julian Sabreur is investigating an attack on top physicist Kay Amal Khan. This leads Julian to clash with agents of an unknown power - and they may or may not be human. His only clue is grainy footage, showing a woman who supposedly died on Bodmin Moor. Dr Khan's research was theoretical; then she found cracks between our world and parallel Earths. Now these cracks are widening, revealing extraordinary creatures. And as the doors crash open, anything could come through." },
                        new Book { Title = "Dear Edward", AuthorId = 3, Genre = Genre.Fiction, NumberOfPages = 352, ImageUrl = "/images/DearEdwardByAnnNapolitano.jpg", PublicationDate = new DateTime(2020, 1, 6), Description = "What does it mean not just to survive, but to truly live? One summer morning, twelve-year-old Edward Adler, his beloved older brother, his parents, and 183 other passengers board a flight in Newark headed for Los Angeles. Among them are a Wall Street wunderkind, a young woman coming to terms with an unexpected pregnancy, an injured veteran returning from Afghanistan, a business tycoon, and a free - spirited woman running away from her controlling husband.Halfway across the country, the plane crashes.Edward is the sole survivor. Edward’s story captures the attention of the nation, but he struggles to find a place in a world without his family.He continues to feel that a part of himself has been left in the sky, forever tied to the plane and all of his fellow passengers.But then he makes an unexpected discovery—one that will lead him to the answers of some of life’s most profound questions: When you’ve lost everything, how do you find the strength to put one foot in front of the other? How do you learn to feel safe again? How do you find meaning in your life? Dear Edward is at once a transcendent coming - of - age story, a multidimensional portrait of an unforgettable cast of characters, and a breathtaking illustration of all the ways a broken heart learns to love again." },
                        new Book { Title = "The Tattooist Of Auschwitz", AuthorId = 4, Genre = Genre.Historic, NumberOfPages = 272, ImageUrl = "/images/TheTattooistOfAuschwitzByHeatherMorris.jpg", PublicationDate = new DateTime(2018, 1, 27), Description = "In April 1942, Lale Sokolov, a Slovakian Jew, is forcibly transported to the concentration camps at Auschwitz-Birkenau. When his captors discover that he speaks several languages, he is put to work as a Tätowierer (the German word for tattooist), tasked with permanently marking his fellow prisoners. Imprisoned for more than two and a half years, Lale witnesses horrific atrocities and barbarism—but also incredible acts of bravery and compassion.Risking his own life, he uses his privileged position to exchange jewels and money from murdered Jews for food to keep his fellow prisoners alive. One day in July 1942, Lale, prisoner 32407, comforts a trembling young woman waiting in line to have the number 34902 tattooed onto her arm.Her name is Gita, and in that first encounter, Lale vows to somehow survive the camp and marry her. A vivid, harrowing, and ultimately hopeful re - creation of Lale Sokolov's experiences as the man who tattooed the arms of thousands of prisoners with what would become one of the most potent symbols of the Holocaust, The Tattooist of Auschwitz is also a testament to the endurance of love and humanity under the darkest possible conditions. " }

                   ) ;
                }

                context.SaveChanges();
            }
        }
    }
}
