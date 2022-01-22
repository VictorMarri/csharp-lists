# Checklist de Pull Request :computer:

## Tipo de Pull Request

- [ ] Correção de Bug
- [ ] Nova Feature
- [ ] Alteração arquitetural

## Tipo de Teste implementado

- [ ] Unitário
- [ ] Integração

## Checks gerais de Pull Request

1. [ ] História foi repassada e Confirmada
2. [ ] Code Review
3. [ ] Validação em Dupla (Funcional)

### Checklist Aprovador

#### Código

- [ ] O padrão de codificação da dti foi seguido
- [ ] Não existem lógicas de negócio desenvolvidas nas queries e mutations
- [ ] As responsabilidades foram corretamente atribuídas nos objetos de negócio

#### Testes automatizados

- [ ] Os testes automatizados foram construídos passando todos os cenários?
- [ ] Os testes automatizados desenvolvidos são assertivos?

## Dicas e Padrões

### Código

- Métodos iniciam com letra maiúscula
- Nome dos métodos estão no infinitivo
- Nome das métodos estão utilizando padrão *PascalCase*
- Há adoção de nomes significativos que contenham a função da variável ou do método
- Os parâmetros de entrada são claros em sua usabilidade nos métodos
- Métodos e/ou funções executam apenas uma função (responsabilidade única)
- Nome das variáveis estão utilizando padrão *camelCase*
- A comunicação com serviços e/ou recursos **externos** ocorre na camada de infraestrutura
- As datas/horas estão usando padrão UTC
- Metodos criados não extrapolam o numero de 5 parametros

### Testes

- Foram realizados testes ***unitários*** para simular:
- Casos de sucesso
- Casos de erro relacionados às validações
- Casos de erro retornado pelos serviços
- Testes que envolvem data/hora executam com sucesso independente de quando e onde são executados?
- Foram realizados testes ***de integração*** para simular:
- Casos de sucesso

### Testes de bancada

- Planejar os testes antes do inicio do desenvolvimento da história
- Verificar fluxos alternativos 
- Considerar critérios de aceitação definidos

### Validação em Dupla

- Banana Cake Pop:
    <br>-> Casos de sucesso
    <br>-> Casos de erros relacionados às validações
    <br>-> Casos de erros retornados pelo serviço
- Garantir publicação em DEV e QAS
