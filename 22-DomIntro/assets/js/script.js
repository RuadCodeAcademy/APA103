const card = document.createElement('div');
card.className = 'card';
Object.assign(card.style, {
    backgroundColor: '#fff',
    width: '380px',
    borderRadius: '12px',
    overflow: 'hidden',
    boxShadow: '0 4px 15px rgba(0,0,0,0.1)',
    fontFamily: "'Segoe UI', Tahoma, Geneva, Verdana, sans-serif"
});


const cardImage = document.createElement('div');
cardImage.className = 'card-image';
Object.assign(cardImage.style, {
    position: 'relative',
    height: '220px'
});

const mainImg = document.createElement('img');
mainImg.src = '/assets/images/sekil1.png';
mainImg.alt = 'Evin şəkli';
Object.assign(mainImg.style, {
    width: '100%',
    height: '100%',
    objectFit: 'cover'
});

const heartIconDiv = document.createElement('div');
heartIconDiv.className = 'heart-icon';
heartIconDiv.innerHTML = '<i class="fa-regular fa-heart"></i>';
Object.assign(heartIconDiv.style, {
    position: 'absolute',
    top: '15px',
    right: '15px',
    color: 'white',
    fontSize: '22px',
    cursor: 'pointer',
    transition: 'transform 0.2s ease'
});


heartIconDiv.addEventListener('click', function() {
    const icon = this.querySelector('i');
    if (icon.classList.contains('fa-regular')) {
        icon.className = 'fa-solid fa-heart';
        this.style.color = '#ff4757';
        this.style.transform = 'scale(1.2)';
    } else {
        icon.className = 'fa-regular fa-heart';
        this.style.color = 'white';
        this.style.transform = 'scale(1)';
    }
});

cardImage.append(mainImg, heartIconDiv);

// 3. Məzmun bölməsi (Card Content)
const cardContent = document.createElement('div');
cardContent.style.padding = '20px';

const propertyType = document.createElement('p');
propertyType.innerText = 'DETACHED HOUSE • 5Y OLD';
Object.assign(propertyType.style, {
    fontSize: '14px',
    fontWeight: 'bold',
    color: '#5f6368',
    margin: '0',
    letterSpacing: '0.5px'
});

const price = document.createElement('h1');
price.innerText = '$750,000';
Object.assign(price.style, {
    fontSize: '32px',
    margin: '10px 0',
    color: '#202124'
});

const address = document.createElement('p');
address.innerText = '742 Evergreen Terrace';
Object.assign(address.style, {
    color: '#70757a',
    fontSize: '18px',
    margin: '0'
});

cardContent.append(propertyType, price, address);


const details = document.createElement('div');
Object.assign(details.style, {
    display: 'flex',
    borderTop: '1px solid #e8eaed',
    borderBottom: '1px solid #e8eaed',
    padding: '15px 20px'
});

function createDetail(iconClass, count, text) {
    const item = document.createElement('div');
    Object.assign(item.style, {
        display: 'flex',
        alignItems: 'center',
        marginRight: '25px',
        color: '#5f6368'
    });
    item.innerHTML = `
        <i class="${iconClass}" style="font-size: 20px; margin-right: 8px;"></i>
        <span style="font-size: 16px;"><strong>${count}</strong> ${text}</span>
    `;
    return item;
}

details.append(
    createDetail('fa-solid fa-bed', '3', 'Bedrooms'),
    createDetail('fa-solid fa-bath', '2', 'Bathrooms')
);


const realtorSection = document.createElement('div');
Object.assign(realtorSection.style, {
    padding: '20px',
    backgroundColor: '#f8f9fa'
});

const realtorLabel = document.createElement('p');
realtorLabel.innerText = 'REALTOR';
Object.assign(realtorLabel.style, {
    fontSize: '12px',
    fontWeight: 'bold',
    color: '#70757a',
    margin: '0 0 10px 0'
});

const realtorInfo = document.createElement('div');
realtorInfo.style.display = 'flex';
realtorInfo.style.alignItems = 'center';

const agentPhoto = document.createElement('img');
agentPhoto.src = '/assets/images/sekil2.png';
Object.assign(agentPhoto.style, {
    width: '50px',
    height: '50px',
    borderRadius: '50%',
    objectFit: 'cover',
    marginRight: '15px'
});

const agentDetails = document.createElement('div');
agentDetails.innerHTML = `
    <h3 style="margin: 0; font-size: 16px; color: #202124;">Tiffany Heffner</h3>
    <p style="margin: 0; font-size: 14px; color: #70757a;">(555) 555-4321</p>
`;

realtorInfo.append(agentPhoto, agentDetails);
realtorSection.append(realtorLabel, realtorInfo);


card.append(cardImage, cardContent, details, realtorSection);
document.body.appendChild(card);

Object.assign(document.body.style, {
    backgroundColor: '#f0f2f5',
    display: 'flex',
    justifyContent: 'center',
    alignItems: 'center',
    height: '100vh',
    margin: '0'
});