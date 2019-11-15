export default function Manufacturers(manufacturers){
    return `
    <div class="manufacturerGrid">
        ${manufacturers
            .map(manufacturer => {
                return `
                <div class="manufacturers">
                    <img class="manufacturer__image" src=${manufacturer.logo}></img>
                    <input class="manufacturer__id" type="hidden" value="${manufacturer.id}">                    
                </div>
                `
            }) 
            .join("")}
    </div>
        

    `
}