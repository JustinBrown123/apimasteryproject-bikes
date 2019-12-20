using Microsoft.EntityFrameworkCore.Migrations;

namespace apimasteryproject_bikes.Migrations
{
    public partial class fixingdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "ID",
                keyValue: 2,
                column: "Description",
                value: "Trek Bicycle Corporation is a bicycle and cycling product manufacturer and distributor under brand names Trek, Electra Bicycle Company, Gary Fisher, Bontrager, Diamant Bikes, Villiger Bikes and, until 2008, LeMond Racing Cycles and Klein. With its headquarters in Waterloo, Wisconsin, Trek bicycles are marketed through 1,700 dealers across North America, subsidiaries in Europe and Asia as well as distributors in 90 countries worldwide. 99% of Trek bicycles are manufactured outside the United States, in countries including the Netherlands, Germany, Taiwan and China.");

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "ID",
                keyValue: 3,
                column: "Description",
                value: "The company was founded in 1971 by Joe Montgomery and Murdock MacGregor to manufacture precast concrete housing. Then Joe Montgomery, after a camping bike trip with his son, conceived the Bugger bicycle trailer. Ron Davis devised the under-seat hitch, a torsion spring made of Lexan. Wistrand designed the cloth bags and cargo carrier on the two models of trailers. Joe, in an effort repeated in numerous products, sourced the cloth components and ensured perfection in their manufacture. A trip to the Bicycle Show in New York was an eye opener.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "ID",
                keyValue: 2,
                column: "Description",
                value: "Trek Bicycle Corporation is a bicycle and cycling product manufacturer and distributor under brand names Trek, Electra Bicycle Company, Gary Fisher, Bontrager, Diamant Bikes, Villiger Bikes and, until 2008, LeMond Racing Cycles and Klein. With its headquarters in Waterloo, Wisconsin, Trek bicycles are marketed through 1,700 dealers across North America, subsidiaries in Europe and Asia as well as distributors in 90 countries worldwide. 99% of Trek bicycles are manufactured outside the United States, in countries including the Netherlands, Germany, Taiwan and China.In December, 1975, Richard (Dick) Burke and Bevil Hogg established Trek Bicycle as a wholly owned subsidiary of Roth Corporation, a Milwaukee-based appliance distributor. In early 1976, with a payroll of five, Trek started manufacturing steel touring frames in Waterloo, Wisconsin, taking aim at the mid to high-end market dominated by Japanese and Italian made models. Trek built nearly 900 custom hand-brazed framesets that first year, each selling for just under $200. Later that same year Trek Bicycle was incorporated. In 1977, Penn Cycle in Richfield, Minnesota became the first Trek dealer in the world. Within three years, Trek sales approached $2,000,000.");

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "ID",
                keyValue: 3,
                column: "Description",
                value: "The company was founded in 1971 by Joe Montgomery and Murdock MacGregor to manufacture precast concrete housing. Then Joe Montgomery, after a camping bike trip with his son, conceived the Bugger bicycle trailer. Ron Davis devised the under-seat hitch, a torsion spring made of Lexan. Wistrand designed the cloth bags and cargo carrier on the two models of trailers. Joe, in an effort repeated in numerous products, sourced the cloth components and ensured perfection in their manufacture. A trip to the Bicycle Show in New York was an eye opener. The team was besieged by bike dealers wanting to buy the bags. They bought trailers too but really wanted the bags. In less than six months Cannondale became the world's largest manufacturer of lightweight bicycle bags. Using a marketing plan devised by Montgomery, Cannondale swept across the US, securing orders from more than 2500 dealers in less than 20 months. They then used the infrastructure developed to produce the bags to enter the camping goods market with backpacks and tents. Regarding the Bugger trailer, although Cannondale's marketing department claimed to be unaware of the connotations of that name in British English, some were, nevertheless, exported to the UK.Once fully immersed in the retail bicycle industry, Todd Patterson, another exceptional designer / inventor, came aboard and developed the process for jigging and welding aluminum bicycle frames.Cannondale became a serious manufacturer of bicycles.");

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "ID", "Description", "Image", "Name" },
                values: new object[] { 4, "Focus Bikes is a bicycle manufacturer that has its administration in Filderstadt, Germany and production facilities based in Cloppenburg, Germany and builds sport bicycles such as e-bikes, racing bicycles and mountain bicycles. The company was founded in 1993 by Mike Kluge, cyclocross World Champion.", "./Images/Focuslogo.jpg", "Focus" });
        }
    }
}
