export default function Manufacturers(manufacturers){
    return `
    <div class="objectGrid">
        ${manufacturers
            .map(manufacturer => {
                return `
                <div class="manufacturers">
                    <img class="manufacturer__image" src=${manufacturer.image}> </img>
                    <input class="manufacturer__name" type="hidden" value="${manufacturer.name}">
                    <input class="manufacturer__id" type="hidden" value="${manufacturer.id}">  
                        
       
                </div>
                `;
            }) 
            .join("")}
    </div>
    
    <div class="adding">
            <input class="add-manufacturer__manufacturerName" type="text" placeholder="Add a Manufacturer">
            <input class="add-manufacturer__manufacturerDescription" type="text" placeholder="Add a Description">
            <input class="add-manufacturer__manufacturerimg" type="hidden" value="./Images/bicycledrawing.jpg">
            <button class="add-manufacturer__submit" id="buttonCrud">Submit</button>
    </div>

    `
}