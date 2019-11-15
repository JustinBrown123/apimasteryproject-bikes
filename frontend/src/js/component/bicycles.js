export default function Bicycles(bicycles){
    return `
    <div class="bicyclesGrid">
        ${bicycles
            .map(bicycle => {
                return `
                <div class="bicycles">
                    <img class="bicycles__image" src=${bicycle.image}></img>
                    <input class="bicycles__id" type="hidden" value="${bicycle.id}">                    
                </div>
                `
            }) 
            .join("")}
    </div>
        

    `
}