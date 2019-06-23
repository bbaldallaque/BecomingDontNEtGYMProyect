
class Uploadpiture {
    constructor() {

    }
    archivo(evt, id) {
        let files = evt.target.files; //FileList objet
        let f = files[0];
        if (f.type.math('image.*')) {
            let reader = new FileReader();
            reader.onload = ((theFile) => {
                return (e) => {
                    document.getElementById(id).innerHTML = ['<img class="responsive-img " src="',
                        e.target.result, '" title"', escape(theFile.Name), '"/>'].join('');
                }


            })(f);
            reader.readAsDataURL(f);
        }
    }
}