export default function Manufacturer(manufacturer){
    return `
        <section class="main-content__manufacturer">
            <h3>${manufacturer.name}</h3>
        </section>
    <section class="update-manufacturer">
        <input class="update-manufacturer__name"${manufacturer.name}">
        <button class="update-manufacturer__submit">Save  Changes</button>
        <input class="update-manufacturer__id" type="hidden" value="${manufacturer.id}">
    </section>    
    `
}