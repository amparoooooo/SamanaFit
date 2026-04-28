SamanáFit Pro


SamanáFit Pro es un sistema inteligente generador de rutinas de entrenamiento personalizadas, 
diseñado para usuarios que desean mejorar su condición física según su objetivo.


```bash
SamanaFitPro/
│
├── SamanaFit.Data/               (Class Library)
│   ├── Entities/
│   │   ├── Usuario.cs
│   │   ├── Objetivo.cs
│   │   ├── Nivel.cs
│   │   ├── Ejercicio.cs
│   │   └── Rutina.cs
│   │
│   └── SamanaFitContext.cs
│
├── SamanaFit.UI/                 (WinForms Project)
│   ├── Services/
│   │   ├── IRutinaService.cs
│   │   └── RutinaService.cs
│   │
│   ├── Forms/
│   │   ├── MainForm.cs
│   │   ├── UsuariosForm.cs
│   │   ├── ObjetivosForm.cs
│   │   ├── NivelesForm.cs
│   │   ├── EjerciciosForm.cs
│   │   ├── RutinasForm.cs
│   │   └── ReportesForm.cs
│   │
│   └── Program.cs
│
└── SamanaFit.Tests/              (xUnit Project)
    └── RutinaServiceTests.cs
```
https://www.figma.com/make/qS8DXGGb2z23CWPJrwlQYo/Design-fitness-dashboard-UI?fullscreen=1&t=2Aguwr6XSe4fDHMt-1

<img width="1634" height="826" alt="image" src="https://github.com/user-attachments/assets/ccbedea9-e0cf-4279-8035-474f65ab6ecc" />
