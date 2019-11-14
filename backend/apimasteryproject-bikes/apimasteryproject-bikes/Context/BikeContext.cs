using apimasteryproject_bikes.Models;
using Microsoft.EntityFrameworkCore;

namespace apimasteryproject_bikes.Context
{
    public class BikeContext : DbContext
    {
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Bicycle> Bicycles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=apimasteryproject-bikes;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString)
            .UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Manufacturer>().HasData(
                new Manufacturer(1, "Specialized", "Logo", "Specialized is an independent US-based bike manufacturer that has been around for 40+ years. Specialized Bicycle Components, Inc., more commonly known simply as Specialized, is a major American brand of bicycles and related products. It was founded in 1974 by Mike Sinyard and is based in Morgan Hill, California."),
                new Manufacturer(2, "Trek", "Logo", "Trek Bicycle Corporation is a bicycle and cycling product manufacturer and distributor under brand names Trek, Electra Bicycle Company, Gary Fisher, Bontrager, Diamant Bikes, Villiger Bikes and, until 2008, LeMond Racing Cycles and Klein. With its headquarters in Waterloo, Wisconsin, Trek bicycles are marketed through 1,700 dealers across North America, subsidiaries in Europe and Asia as well as distributors in 90 countries worldwide. 99% of Trek bicycles are manufactured outside the United States, in countries including the Netherlands, Germany, Taiwan and China.In December, 1975, Richard (Dick) Burke and Bevil Hogg established Trek Bicycle as a wholly owned subsidiary of Roth Corporation, a Milwaukee-based appliance distributor. In early 1976, with a payroll of five, Trek started manufacturing steel touring frames in Waterloo, Wisconsin, taking aim at the mid to high-end market dominated by Japanese and Italian made models. Trek built nearly 900 custom hand-brazed framesets that first year, each selling for just under $200. Later that same year Trek Bicycle was incorporated. In 1977, Penn Cycle in Richfield, Minnesota became the first Trek dealer in the world. Within three years, Trek sales approached $2,000,000."),
                new Manufacturer(3, "Cannondale", "Logo", "The company was founded in 1971 by Joe Montgomery and Murdock MacGregor to manufacture precast concrete housing. Then Joe Montgomery, after a camping bike trip with his son, conceived the Bugger bicycle trailer. Ron Davis devised the under-seat hitch, a torsion spring made of Lexan. Wistrand designed the cloth bags and cargo carrier on the two models of trailers. Joe, in an effort repeated in numerous products, sourced the cloth components and ensured perfection in their manufacture. A trip to the Bicycle Show in New York was an eye opener. The team was besieged by bike dealers wanting to buy the bags. They bought trailers too but really wanted the bags. In less than six months Cannondale became the world's largest manufacturer of lightweight bicycle bags. Using a marketing plan devised by Montgomery, Cannondale swept across the US, securing orders from more than 2500 dealers in less than 20 months. They then used the infrastructure developed to produce the bags to enter the camping goods market with backpacks and tents. Regarding the Bugger trailer, although Cannondale's marketing department claimed to be unaware of the connotations of that name in British English, some were, nevertheless, exported to the UK.Once fully immersed in the retail bicycle industry, Todd Patterson, another exceptional designer / inventor, came aboard and developed the process for jigging and welding aluminum bicycle frames.Cannondale became a serious manufacturer of bicycles."),
                new Manufacturer(4, "Focus", "Logo", "Focus Bikes is a bicycle manufacturer that has its administration in Filderstadt, Germany and production facilities based in Cloppenburg, Germany and builds sport bicycles such as e-bikes, racing bicycles and mountain bicycles. The company was founded in 1993 by Mike Kluge, cyclocross World Champion."),
                new Manufacturer(5, "Kona", "Logo", "Kona Bikes is a bicycle company based in the Pacific Northwest. The company was founded in 1988 by Dan Gerhard and Jacob Heilbron in Vancouver, British Columbia, Canada."),
                new Manufacturer(6, "Transition", "Logo", "Depending on who you ask, Transition Bikes was either established in 2001 or in 2003. It's a long-running debate between Kyle Young and Kevin Menard, the company's founders. Kevin says it was in 2001, when the idea of starting a bike company came to the surface over a game of ping-pong, while Kyle asserts that it was 2003, when the first shipment of 100 bikes arrived in the US.")
                );

            modelBuilder.Entity<Bicycle>().HasData(
                new Bicycle(1, "S-Works Shiv", "Image", "On the bike leg of any triathlon, speed and efficiency win the game. The S-Works Shiv is the ultimate speed weapon for any triathlon distance, and it's purpose-built to take your bike leg to the next level.", "TT", 1),
                new Bicycle(2, "Boone", "Image", "Boone is our fastest, smoothest, lightest Cross bike ever, with competition-crushing race geometry and our exclusive course-smoothing IsoSpeed technology. Smooth and balanced. Front and Rear IsoSpeed make easy work of the roughest courses. These innovative decouplers reduce jarring impacts so you ride stronger, longer.", "Cyclocross", 2),
                new Bicycle(3, "SystemSix", "Image", "SystemSix is truly in a class of its own. Newly crowned 2019 Race Bike of the Year by BikeRadar/Cycling Plus Magazine and the fastest bike tested by Tour Magazine.", "Road", 3),
                new Bicycle(4, "Big Bird", "Image", "After three years of intensive development, FOCUS have finally lifted the veil of secrecy and revealed the latest stage of mountain biking’s evolution. Alongside the FOCUS XC Team and Florian Vogel, this super-sized bike has come out of development and onto the market. Bike developers and pros stand united: this racing machine marks a milestone in mountain biking history. The Cloppenburg-based brand have once again redefined comfort, speed and grip.", "Mountain", 4),
                new Bicycle(5, "Izalco Chrono", "Image", "Hard and fast flat-course machine for aggressive athletes prepared to sacrifice comfort for all-out speed. Co-created five years ago by Andreas Walser, one of Europe’s top custom aero frame-builders, can the minimal-profile Focus Izalco Chrono 2.0 20-G still slice its way through the air and the competition?", "TT", 4),
                new Bicycle(6, "KonaSutra", "Image", "The Sutra is many things. It's gorgeous. It's stylish. It's incredibly versatile, and it comes ready for the long haul on the bike tour of your dreams. Our Kona Cromoly steel frame is outfitted with a Brooks saddle, cork bar tape, BarCon shifters, fenders and rack.", "Commuter", 5),
                new Bicycle(7, "Patrol Carbon X01", "Image", "Being one of our most versatile bikes in the lineup, it was a natural fit to take the suspension to the next level. ... If you need your bike to be a daily driver for your local trails as well as your bike park and shuttle session steed, the Patrol is the perfect choice.", "Mountain", 6)
                );
            base.OnModelCreating(modelBuilder);
        }

    }
}
