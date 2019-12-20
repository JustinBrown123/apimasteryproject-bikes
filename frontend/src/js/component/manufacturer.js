export default function Manufacturer(manufacturer){
    return `

    <div class = "editObject">
    <h3>${manufacturer.name}</h3>
        <h3>Edit Name</h3>
        <input class="update-manufacturer__name"${manufacturer.name}">
        <h3>Edit Description</h3>
        <input class="update-manufacturer__description"${manufacturer.description}">
        <button class="update-manufacturer__submit" id="buttonCrud">Save  Changes</button>
        <input class="update-manufacturer__id" type="hidden" value="${manufacturer.id}">
    </div>    
    `
}