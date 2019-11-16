export default function Manufacturer(manufacturer){
    return `
        <section class="main-content__manufacturer">
            <h3>${manufacturer.name}</h3>
        </section>
    <section class="update-object">
        <h3>Edit Name</h3>
        <input class="update-manufacturer__name"${manufacturer.name}">
        <h3>Edit Description</h3>
        <input class="update-manufacturer__description"${manufacturer.description}">
        <button class="update-manufacturer__submit">Save  Changes</button>
        <input class="update-manufacturer__id" type="hidden" value="${manufacturer.id}">
    </section>    
    `
}