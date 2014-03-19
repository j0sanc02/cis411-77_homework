namespace SanchezPetStore.Migrations
{
    using SanchezPetStore.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SanchezPetStore.Models.AnimalDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "SanchezPetStore.Models.AnimalDBContext";
        }

        protected override void Seed(SanchezPetStore.Models.AnimalDBContext context)
        {
            context.Animal.AddOrUpdate(i=>i.Name,

                new Animals
                {
                  Imagepath = "~/Content/Images/Boxer.jpg",
                  Name = "Susie",
                  Description = "The Boxer is a breed of stocky, medium-sized, short-haired dogs developed in Germany. Their coat is smooth and tight-fitting; colors are fawn or brindled, with or without white markings, which may cover the entire body, and white. Boxers are brachycephalic (they have broad, short skulls), have a square muzzle, mandibular prognathism (an underbite), very strong jaws, and a powerful bite ideal for hanging on to large prey. The Boxer was bred from the Old English Bulldog and the now extinct Bullenbeisser, and is part of the Molosser group.",
                  DateReceived = DateTime.Parse("2013-04-13"),
                  Quantity = 3,
                  Price = 1000.00M
                },

                new Animals
                {
                    Imagepath = "~/Content/Images/GreatDane.jpg",
                    Name = "Roger",
                    Description ="Great Dane, breed of working dog developed at least 400 years ago in Germany, where it was used for boar hunting. The Great Dane is typically a swift, alert dog noted for courage, friendliness, and dependability. It has a massive, square-jawed head and body lines that give it an elegant appearance. Its short coat is black, fawn (golden brown), brindle, blue-gray, harlequin (white with black patches), or mantle (white with a black “blanket” extending over the body). The fawn and brindle dogs have a black mask. The Great Dane is the tallest of the working breeds, with males standing at least 30 inches (76 cm) and females at least 28 inches (71 cm); it weighs 120 to 150 pounds (54 to 68 kg). Its name was derived from one of its French names, Grand Danois (Big Danish), although there is no known reason to associate Denmark with the history or origin of the breed. In Germany the breed is called the Deutsche Dogge (German dog)." ,
                    DateReceived = DateTime.Parse("2012-03-13"),
                    Quantity = 2,
                    Price = 1075.00M
                },
                new Animals
                {
                    Imagepath="~/Content/Images/Bulldog.jpg",
                    Name = "Skyler",
                    Description = "The English Bulldog is a wide, medium-sized, compact dog with short legs. The body and head are massive with extra skin on both the skull and forehead falling in folds. The cheeks extend to the sides of the eyes. The muzzle is wide, short and pug with a broad, deep stop. The black nose is broad with large nostrils. The dark eyes are deep set. The rose ears are small, thin and set high on the head. The jaws are massive, very broad, and square with hanging upper lips. The teeth should have an under bite. The tail is either straight or screwed and carried low. The short, flat coat is straight, smooth and glossy. Coat colors include red brindle and other shades of brindle, solid white, solid red, fawn, fallow, piebald, pale yellow or washed-out red or white or a combination of these colors.",
                    DateReceived = DateTime.Parse("2013-02-03"),
                    Quantity = 6,
                    Price = 980.00M
                },

                new Animals
                {
                    Imagepath="~/Content/Images/Chihuahua.jpg",
                    Name = "Pepper",
                    Description = "The Chihuahua is a tiny toy sized dog. The body is longer than it is tall. The head is well-rounded, apple in shape and the muzzle is short and pointed with a well-defined stop. Puppies have a soft spot on the top of the skull called a molera, which usually closes by adulthood. The large, round eyes are set well apart and are dark, ruby, and may be lighter in white dogs. The erect ears are large. Dewclaws may be removed. The tail is long, sickle-shaped and either curled over the back or to the side. The coat can be short, long and wavy or flat. All colors, both solid, marked or splashed are accepted. Colors include, but are not limited to, black, white, chestnut, fawn, sand, silver, sable, steel blue, black & tan and parti-color.",
                    DateReceived = DateTime.Parse("2011-06-05"),
                    Quantity = 10,
                    Price = 380.00M
                },
               
                new Animals
                {
                    Imagepath="~/Content/Images/Dachshund.jpg",
                    Name = "Penelope",
                    Description = "The dachshund is a short-legged, long-bodied dog breed belonging to the hound family. The standard size dachshund was bred to scent, chase, and flush out badgers and other burrow-dwelling animals, while the miniature dachshund was developed to hunt smaller prey such as rabbits. In the American West they have also been used to hunt prairie dogs. Today, they are bred for conformation shows and as family pets. Some dachshunds participate in earthdog trials. According to the AKC, the dachshund continues to remain one of the top 10 dog breeds in the United States.",
                    DateReceived = DateTime.Parse("2012-04-15"),
                    Quantity = 9,
                    Price = 440.00M
                },
                                
                new Animals
                {
                    Imagepath="~/Content/Images/Dalmatian.jpg",
                    Name = "Achilles",
                    Description = "The Dalmatian is a breed of dog named after the historical region of Dalmatia. The Dalmatian is noted for its unique black or liver spotted coat and was mainly used as a carriage dog in its early days. Today, this dog remains a well-loved family pet, and many dog enthusiasts enter their pets into kennel club competitions.",
                    DateReceived = DateTime.Parse("2011-07-17"),
                    Quantity = 5,
                    Price = 470.00M
                },
                                
                new Animals
                {
                    Imagepath="~/Content/Images/GermanShepherd.jpg",
                    Name = "Max",
                    Description = "The German Shepherd Dog is well proportioned and very strong. The GSD has a sturdy, muscular, slightly elongated body with a light, solid bone structure. The head should be in proportion to its body, and the forehead a little rounded. The nose is most often black, however, blue or liver still do sometimes occur, but are considered a fault and cannot be shown. The teeth meet in a strong scissors bite. The dark eyes are almond-shaped, and never protruding. The ears are wide at the base, pointed, upright and turned forward. The ears of puppies under six months may droop slightly. The bushy tail reaches below the hocks and hangs down when the dog is at rest. The front legs and shoulders are muscular and the thighs are thick and sturdy. The round feet have very hard soles. There are three varieties of the German Shepherd: double coat, plush coat and longhaired coat. The coat most often comes in black with tan, sable or all black, but also can come in white, blue and liver, but those colors are considered a fault according to most standards. The white GSD dogs are recognized as a separate breed by some clubs and are being called the American White Shepherd. A piebald color has also occurred in a single GSD bloodline that is now being called a Panda Shepherd. A Panda is 35% white the remainder of color is black and tan, and has no white German Shepherds in its ancestry.",
                    DateReceived = DateTime.Parse("2010-04-14"),
                    Quantity = 3,
                    Price = 490.00M
                },

                new Animals
                {
                    Imagepath="~/Content/Images/IrishWolfHound.jpg",
                    Name = "Tiny",
                    Description = "The Irish Wolfhound is a breed of domestic dog (Canis lupus familiaris), specifically a sighthound. The name originates from its purpose (wolf hunting with dogs) rather than from its appearance. The breed was originally developed from war hounds to one used for hunting and guarding. Irish Wolfhounds can be an imposing sight due to their formidable size; they are the tallest of all dog breeds.",
                    DateReceived = DateTime.Parse("2013-08-30"),
                    Quantity = 1,
                    Price = 1490.00M
                },

                new Animals
                {
                    Imagepath="~/Content/Images/Maltese.jpg",
                    Name = "Darwin",
                    Description = "The Maltese is a small breed of dog in the Toy Group. It descends from dogs originating in the Central Mediterranean Area. The breed name and origins are generally understood to derive from the Mediterranean island nation of Malta; however, the name is sometimes described with reference to the distinct Adriatic island of Mljet, or a defunct Sicilian town called Melita.",
                    DateReceived = DateTime.Parse("2011-03-12"),
                    Quantity = 8,
                    Price = 390.00M
                },

                new Animals
                {
                    Imagepath="~/Content/Images/Yorkie.jpg",
                    Name = "Killer",
                    Description = "The Yorkshire Terrier is a small dog breed of terrier type, developed in the 19th century in the county of Yorkshire, England, to catch rats in clothing mills, also used for rat-baiting. The defining features of the breed are its maximum size of 7 pounds (3.2 kg) and its gray, black, and tan coat. The breed is nicknamed Yorkie and is placed in the Toy Terrier section of the Terrier Group by the Fédération Cynologique Internationale and in the Toy Group or Companion Group by other kennel clubs, although all agree that the breed is a terrier. A popular companion dog, the Yorkshire Terrier has also been part of the development of other breeds, such as the Australian Silky Terrier.",
                    DateReceived = DateTime.Parse("2014-01-01"),
                    Quantity = 7,
                    Price = 590.00M
                }
                        
              );            
            
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
