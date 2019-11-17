export default function Editbicycle(bicycle){
    return `

    <section class="update-object">
    <div class ="editObject">
        <h3> Make Changes to: ${bicycle.name}</h3>
        <input class="update-bicycle__name" type='text' placeholder='Edit  Bicycle Name'>
        <input class="update-bicycle__description"  type='text' placeholder='Edit Bicycle descriptions'>
        <input class="update-bicycle__style"  type='text' placeholder='Edit Bicycle Style'>      
        <input class="update-bicycle__manufacturerid" type='hidden' value="${bicycle.manufacturerID}">   
        <input class="update-bicycle__image" type='hidden' value="${bicycle.image}">       
        <button class="update-bicycle__submit">Save  Changes</button>
        <input class="update-bicycle__id" type="hidden" value="${bicycle.id}">
        </div>
    </section>    
    `
}