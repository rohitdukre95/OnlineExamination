function getSummerNote(id,heightValue,widthValue) {
    if (id !== "" && id !== undefined)
    {
        $('#' + id).summernote({
            placeholder: 'Write question here...',
            tabsize: 2,
            height: heightValue,
            width: widthValue,
            toolbar: [
                ['style', ['style']],
                ['font', ['bold', 'underline', 'clear']],
                ['color', ['color']],
                ['para', ['ul', 'ol', 'paragraph']],
                ['table', ['table']],
                ['insert', ['link', 'picture', 'video']],
                ['view', ['fullscreen', 'codeview', 'help']]
            ]
        });
    }
}