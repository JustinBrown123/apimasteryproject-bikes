using Microsoft.EntityFrameworkCore.Migrations;

namespace apimasteryproject_bikes.Migrations
{
    public partial class AddedBicycle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "ID", "Description", "Image", "Name" },
                values: new object[] { 7, "BUILT IN BRITAIN, We work with partners all over the world to source many of our our frames and components, today we’re talking specifically about the British built models.We started production of our full - suspension frames in Halifax in 1998.It seemed the easiest way to get the development we needed for the frame ideas we were pursuing.Well it turned out not to be ‘easy’, but it did turn out to be successful, and the rest, as they say, is history. Since those intrepid beginnings we have built a lot of frames and learned plenty.While experience has taught us a lot, the little tweaks and tricks that we have learned in the building process aren’t necessarily obvious in the final frame, but they are crucial steps to producing some of the strongest and most reliable high - performance mountain bikes in the world. IT’S NOT SO SIMPLE The best ideas are always the simplest, right ? In bike development terms the Orange bikes are just that, a great idea done simply, but more importantly done well. We are often asked why we don’t make frames the same as everyone else. Well, thanks for asking but we really like the the way we do it.And so do the people who buy Orange bikes and try to ride the wheels off them. We simply build bikes to be ridden not to be hung on the wall and admired(although you can do that too, if you want). While we are open-minded to new ideas, we’re adamant about ensuring change is for the better and not just a marketing fad.We use our STrange R & D prototype program to sort the wheat from the chaff. ", "./Images/Orange.jpg", "Orange" });

            migrationBuilder.InsertData(
                table: "Bicycles",
                columns: new[] { "ID", "Description", "Image", "ManufacturerID", "Name", "Style" },
                values: new object[] { 8, "The Orange Crush is a bike you don't want to mess with. It's loved and revered, with award winning performance. It's the definitive aluminium hardcore hardtail. The frame is bang on point, the rear triangle features a 148 Boost bolt - through axle, giving unparalleled stability to what is already a strong and rigid chassis.The new model's geometry has been tweaked with a 64° head angle which, matched with the Crush’s long top tube design, adds an extra degree of confidence in the handling. With a short 50mm stem the rider is right where they need to be for direct control and weight distribution. Short chainstays make climbing as sweet as ever for a long-forked hardtail, those stays now reshaped with a CNCed yoke on the chainstay to allow plenty of clearance for a more than chunky 2.6 tyre. The Crush’s unshakeable attitude is as strong as ever.Built tough to be ridden hard, where it really excels, on the rough stuff.", "./Images/OrangeCrush.jpg", 7, "Orange Crush", "Mountain" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bicycles",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "ID",
                keyValue: 7);
        }
    }
}
