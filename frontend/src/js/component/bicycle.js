export default function bicycle(bicycle){
    return `
        <section class="main-content__bicycle">
            <h3>${bicycle.name}</h3>          
            <img class="bicycleImage" src=${bicycle.image}></img>
            <h4>${bicycle.type}</h4>
            <p>${bicycle.description}</p>
        </section>
    <section class="update-bicycle">
        <input class="update-bicycle__name"${bicycle.name}">
        <button class="update-bicycle__submit">Save  Changes</button>
        <input class="update-bicycle__id" type="hidden" value="${bicycle.id}">
    </section>    
    `
}