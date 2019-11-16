export default function Manufacturers(manufacturers){
    return `
    <div class="manufacturerGrid">
        ${manufacturers
            .map(manufacturer => {
                return `
                <div class="manufacturers">
                    <img class="manufacturer__image" src=${manufacturer.image}> </img>
                    <input class="manufacturer__id" type="hidden" value="${manufacturer.id}">  
                    <button class="manufacturer__bikes">Available Bikes</button>            
                </div>
                `;
            }) 
            .join("")}
    </div>
    
    <section class="add-item">
            <input class="add-manufacturer__manufacturerName" type="text" placeholder="Add a Manufacturer">
            <input class="add-manufacturer__manufacturerDescription" type="text" placeholder="Add a Description">
            <input class="add-manufacturer__manufacturerimg" type="hidden" value="./Images/bicycledrawing.jpg">
            <button class="add-manufacturer__submit">Submit</button>
    </section>

    `
}