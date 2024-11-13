export class ShareComponent {
    constructor() {
    }
    
    share(title, text, url) {
        const data = {title, text, url};
        return navigator.share(data).catch((error) => {
            console.log('Error sharing:', error);
        });
    }
}

export const Share = new ShareComponent();