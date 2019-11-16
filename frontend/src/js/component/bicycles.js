export default function Bicycles(bicycles){
    return `
    <div class="bicyclesGrid">
        ${bicycles
            .map(bicycle => {
                return `
                <div class="bicycles">
                    <img class="bicycleImage" src=${bicycle.image}></img>
                    <input class="bicycle__id" type="hidden" value="${bicycle.id}">                    
                </div>
                `
            }) 
            .join("")}
    </div>
        

    `
}