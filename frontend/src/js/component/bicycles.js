export default function Bicycles(bicycles){
    return `
    <div class="objectGrid">
        ${bicycles
            .map(bicycle => {
                return `
                <div class="bicycles">
                <h3>${bicycle.name}</h3>
                    <img class="bicycleImage" src=${bicycle.image}></img>
                    <input class="bicycle__id" type="hidden" value="${bicycle.id}">                    
                </div>
                `
            }) 
            .join("")}
    </div>
        

    `
}