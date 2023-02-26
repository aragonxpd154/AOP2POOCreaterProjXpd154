// cria um novo nó com valor 10
struct Node* newNode = (struct Node*)malloc(sizeof(struct Node));
newNode->data = 10;
newNode->next = NULL;

// adiciona o novo nó no início da lista
newNode->next = head; // head é um ponteiro para o primeiro nó da lista
head = newNode; // atualiza o ponteiro da cabeça da lista para apontar para o novo nó
