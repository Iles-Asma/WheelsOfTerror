# Projet d'exercice MMI 2025

# Setup

## Dupliquer le dépôt d'exercice
> [!NOTE]
> Étapes extraites du tutorial Git pour [Dupliquer un référentiel](https://docs.github.com/fr/pull-requests/collaborating-with-pull-requests/working-with-forks/fork-a-repo#forking-a-repository)

1. Dans le coin supérieur droit de la page, cliquez sur **Fork**.
2. Sous « Propriétaire », sélectionnez le menu déroulant et cliquez sur un propriétaire pour le dépôt dupliqué.
3. Dans le champ « Nom du dépôt », changer le nom du référentiel en suffixant par votre prénom.
4. Sélectionnez "Copier la branche **PAR DÉFAUT** uniquement".
5. Cliquez sur "**Créer une duplication**".

## Cloner le dépôt dupliqué
> [!NOTE]
> Étapes extraites du tutorial Git pour [Cloner un dépôt dupliqué](https://docs.github.com/fr/pull-requests/collaborating-with-pull-requests/working-with-forks/fork-a-repo#cloning-your-forked-repository)

1. Sur GitHub.com, accédez à votre duplication du dépôt
2. Au-dessus de la liste des fichiers, cliquez sur Code.
3. Copiez l’URL du dépôt.
4. Ouvrez [Git Bash](https://git-scm.com/downloads)
5. Naviguez jusqu'à l’emplacement où vous voulez mettre le répertoire cloné en utilisant la [commande _cd_](https://graphite.dev/guides/change-directories-git-bash-windows)
6. Tapez git clone, puis collez l’URL que vous avez copiée précédemment.
7. Appuyez sur Entrée. Votre clone local va être créé.

## Ouvrir votre projet Unity

1. Ouvrez Unity Hub et sélectionnez l'onglet Projects dans la barre de menu à gauche
2. Appuyez sur le bouton Add en haut à droite
3. Sélectionnez le répertoire du projet
4. Cliquez sur le bouton Open et attendez l'ouverture du projet

# Premiers pas dans Unity

> [!NOTE]
> Pour plus de détails vous pouvez suivre le tutorial [ici](https://learn.unity.com/tutorial/explore-the-unity-editor-1)

## L'interface de l'éditeur
![Image d'illustration dez zones de l'éditeur](https://unity-connect-prd.storage.googleapis.com/20220606/learn/images/7fabb375-5282-4852-9ecf-d8acc254052b_EditorExplore.png)

### Scene view et Game view 
Zones de visualisation des objets 3D (**Scene**) et la vue joueur (**Game**)
> [!TIP]
> Avec le layout par défaut la Game View apparaît au même endroit. Utiliser les onglets pour naviguer.

### Hierarchy window 
Collection d’objets dans la scene.

### Project window 
Équivalent d’un explorateur de fichiers pour le projet.

### Toolbar 
Outils de navigation et de manipulation dans la scène

### Inspector window 
Panneau de configuration d’un objet sélectionné.

## Manipuler les objets 3D
![Image d'illustration des outils de transformation](https://unity-connect-prd.storage.googleapis.com/20220601/learn/images/057c859e-04d5-429a-b980-b852a80b2015_gizmos.png)

- W: Outil de déplacement, pour sélectionner et bouger un objet
- E: Outil de rotation, pour sélectionner et tourner un objet
- R: Outil de dimensionnement, pour sélection et changer la taille d'un objet

> [!TIP]
> Utilisez les raccourcis par défaut W (Move), E (Rotate), R (Scale) pour sélectionner l'outil rapidement.

Pour chacun des outils de transformation, un Gizmo apparaît qui vous permet de manipuler le GameObject le long de chaque axe spécifique. 
Lorsque vous manipulez ces contrôles, les valeurs du composant Transform changent en conséquence.

## Créer une nouvelle scène
### Scène vide
1. Ouvrez le dossier **Assets/Scenes** dans la fenêtre Project
2. Cliquez droit pour ouvrir le menu contextuel
3. Sélectionnez **Create/Scene** 
4. Nommez la scène

### Template
1. Ouvrez le menu **File / New Scene…**
2. Sélectionnez le template souhaité
3. Sauvegardez la scène ouverte

### Ajouter la nouvelle scène au build
1. Ouvrez le sous-menu **Build Settings** depuis le menu **File**
2. Glissez/déposez la nouvelle scène
> [!TIP]
> Utilisez le raccourcis Ctrl+Shift+B pour ouvrir rapidement les Build Settings

## Prefabs

Un Prefab agit comme un modèle à partir duquel vous pouvez créer de nouvelles instances préfabriquées d'un GameObject dans la scène. 
Cela vous permet de créer, configurer et stocker un GameObject complet avec tous ses composants, valeurs de propriété et enfants en tant qu'asset réutilisable.

### Créer un Prefab
> [!NOTE]
> Plus de détails dans le [manuel](https://docs.unity3d.com/Manual/CreatingPrefabs.html)

Faites glisser un GameObject de la fenêtre Hierarchy vers la fenêtre Project.
Le GameObject, ainsi que tous ses composants et enfants, deviennent un nouvel Asset dans votre fenêtre Project. 

> [!TIP]
> Ce processus de création du Prefab transforme également le GameObject d'origine en une instance du nouveau Prefab.

Les Prefabs dans la fenêtre Project sont affichés avec une vue miniature du GameObject ou l'icône Prefab en forme de cube bleu en fonction de la manière dont vous avez paramétré l'affichage.

![Image d'illustration](https://docs.unity3d.com/uploads/Main/PrefabsInProjectWindow1.png)
	
Toutes les modifications sont automatiquement répercutées dans les instances du Prefab modifié. 
Cela permet des changements à l'échelle du projet sans avoir à effectuer à plusieurs reprises la même modification sur chaque copie de l'élément.

Vous pouvez remplacer les paramètres des instances de Prefab individuelles si vous souhaitez que certaines instances d'un Prefab diffèrent des autres. 
Vous pouvez également créer des variantes de Prefab qui vous permettent de regrouper un ensemble de remplacements dans une variation significative d'un Prefab appelée Prefab Variant.

### Modifier un Prefab
> [!NOTE]
> Plus de détails dans le [manuel](https://docs.unity3d.com/Manual/EditingInPrefabMode.html)

Ouvrez-le dans le Prefab Mode en cliquant sur la flèche à droite de son nom dans la scène.
Ou en double-cliquant sur le Prefab dans la fenêtre Project.

![Image d'illustration](https://docs.unity3d.com/uploads/Main/PrefabHierarchyOpenArrow.png)

Ce mode vous permet d'afficher et de modifier le contenu du Prefab séparément de tout autre GameObject dans votre scène. 
Les modifications que vous effectuez dans le Prefab Mode affectent toutes les instances de ce Prefab.

![Image d'illustration](https://docs.unity3d.com/uploads/Main/PrefabContextVsIsolation.png)

En Prefab Mode, la vue Scene affiche une barre de navigation en haut. 
L'entrée la plus à droite correspond au Prefab actuellement ouvert. 
Utilisez la barre de navigation pour revenir aux scènes principales ou aux autresPrefabs que vous avez peut-être ouvertes en naviguant la hiérarchie.

### Prefab Variants
> [!NOTE]
> Plus de détails dans le [manuel](https://docs.unity3d.com/Manual/PrefabVariants.html)

Une variante de Prefab hérite des propriétés d'un autre Prefab, appelée la base. 
Les modifications apportés à la variante de Prefab ont priorité sur les valeurs de la base. 
Une variante de Prefab peut avoir n'importe quelle autre Prefab comme base, y compris les Prefab de modèle ou d'autres variantes de Prefab.

Les Prefab Variant sont affichées avec l'icône préfabriquée bleue décorée de flèches.

![Image d'illustration](https://docs.unity3d.com/uploads/Main/PrefabsBasicAndVariant.png)

Cliquez avec le bouton droit sur un Prefab dans la vue Project et sélectionner Create > Prefab Variant. 
Cela crée une variante du Prefab sélectionné, qui ne comporte initialement aucune substitution. 
Vous pouvez ouvrir la variante de Prefab dans le Prefab Mode pour commencer à y ajouter des substitutions.

Vous pouvez également faire glisser une instance de Prefab de la **Hierarchy** vers la fenêtre **Project**. 
Une boîte de dialogue vous demande si vous souhaitez créer un nouveau Prefab ou un Prefab Variant. 
Si vous choisissez Prefab Variant, vous obtenez une nouvelle variante basée sur l'instance de Prefab que vous avez fait glisser. 
Toutes les substitutions que vous aviez sur cette instance se trouvent désormais à l'intérieur de la nouvelle variante. 
Vous pouvez l'ouvrir dans le Prefab Mode pour ajouter des substitutions supplémentaires ou pour modifier ou supprimer des substitutions.

## Créer un nouveau script
> [!NOTE]
> Plus de détails dans le [manuel](https://docs.unity3d.com/Manual/CreatingAndUsingScripts.html)

- À partir du menu Créer en haut à gauche du panneau Projet
- À partir du menu contextuel (clic droit) Create / C# Script
- En sélectionnant Assets > Create > C# Script dans le menu principal

> [!TIP]
> Lorsque vous créez un script C# à partir de la fenêtre de projet d’Unity, il hérite automatiquement de [MonoBehaviour](https://docs.unity3d.com/Manual/class-MonoBehaviour.html) et vous fournit un template.

## Ajouter un nouveau component
> [!NOTE]
> Plus de détails dans le [manuel](https://docs.unity3d.com/Manual/UsingComponents.html)

Une fois sélectionné le GameObject
- À partir du menu Component si il s'agit d'un composant natif
- Par le Component Browser dans l'inspecteur

## Input System
> [!NOTE]
> Plus de détails dans le [manuel](https://docs.unity3d.com/Packages/com.unity.inputsystem@1.11/manual/index.html)

Obtenir un Input directement à partir d'un périphérique d'entrée est rapide et pratique, mais nécessite un chemin distinct pour chaque type de périphérique.
Cela rend également plus difficile de modifier ultérieurement le contrôle du périphérique qui déclenche un événement spécifique dans le jeu.

À la place il est possible d'utiliser les actions comme intermédiaire entre les Inputs des périphériques et les réponses qu'ils déclenchent.
Le moyen le plus simple est d'utiliser le composant PlayerInput sur le GameObject d'un joueur. 

> [!IMPORTANT]
> Chaque PlayerInput représente un joueur différent dans le jeu.

### Modifier un asset Input Action

Pour afficher l'éditeur d'actions
- double-cliquez sur un élément .inputactions dans le navigateur de projet
- ou sélectionnez le bouton Modifier l'élément dans l'inspecteur de cet élément

L'éditeur d'actions apparaît sous la forme d'une fenêtre distincte, que vous pouvez également ancrer dans l'interface  pour ne pas avoir à accéder à l'asset systématiquement.

![Image d'illustration](https://docs.unity3d.com/Packages/com.unity.inputsystem@1.11/manual/images/ActionsEditorCallout.png)

> [!CAUTION]
> Par défaut, Unity n'enregistre pas les modifications que vous effectuez dans l'éditeur d'actions lorsque vous enregistrez le projet.
> Pour enregistrer vos modifications, sélectionnez Save Asset dans la barre d'outils de la fenêtre.
> Ou bien activez l'enregistrement automatique en activant la case à cocher Auto Save dans la barre d'outils.

## Collider Interactions
> [!NOTE]
> Plus de détails dans le [manuel](https://docs.unity3d.com/Manual/collider-interactions.html)

Lorsque deux Colliders entrent en contact, vous pouvez appeler des fonctions pour déclencher d'autres événements dans votre projet via des scripts.

> [!CAUTION]
> Les événements Collider nécessitent une configuration via un script C# ; vous ne pouvez pas les configurer en utilisant uniquement l'interface utilisateur.

#### Collision events
Ces événements se produisent lorsque deux Colliders entrent en contact et qu'aucun des collisionneurs n'a la fonction Déclencheur activée.

#### Trigger events 
Ces événements se produisent lorsque deux Colliders entrent en contact, qu'au moins un Collider a l'option IsTrigger activée et qu'au moins un Collider a un Rigidbody ou ArticulationBody.

### OnCollision events

Le travail avec les événements de collision implique principalement les fonctions API suivantes :

[Collider.OnCollisionEnter](https://docs.unity3d.com/ScriptReference/Collider.OnCollisionEnter.html) : Appelée sur chaque GameObject lorsque deux Colliders entrent en contact pour la première fois.

[Collider.OnCollisionStay](https://docs.unity3d.com/ScriptReference/Collider.OnCollisionStay.html) : Appelée sur chaque GameObject une fois par mise à jour physique lorsque deux Colliders sont en contact.

[Collider.OnCollisionExit](https://docs.unity3d.com/ScriptReference/Collider.OnCollisionExit.html) : Appelée sur chaque GameObject lorsque deux Colliders cessent le contact.

> [!CAUTION]
> Pour les Collision events, au moins un des objets impliqués doit avoir un corps physique dynamique (c'est-à-dire un Rigidbody ou un ArticulationBody dont l'option IsKinematic est désactivée). 

> [!WARNING]
> Si les deux GameObjects d'une collision sont des corps physiques Kinematic, la collision n'appelle pas les fonctions OnCollision.

### OnTrigger events

Les Triggers Colliders ne provoquent pas de collisions. 
Au lieu de cela, ils détectent les autres **Colliders** qui les traversent et appellent des fonctions que vous pouvez utiliser pour déclencher des événements.

L'utilisation de Trigger Collider implique principalement les fonctions API suivantes :

[Collider.OnTriggerEnter](https://docs.unity3d.com/ScriptReference/Collider.OnTriggerEnter.html) : Appelée sur un GameObject qui possède un Collider en mode IsTrigger lorsqu'il entre en contact pour la première fois avec un autre Collider.

[Collider.OnTriggerStay](https://docs.unity3d.com/ScriptReference/Collider.OnTriggerStay.html) : Appelée sur un GameObject qui possède un Collider en mode IsTrigger une fois par image s'il détecte un autre Collider à l'intérieur de ses limites.

[Collider.OnTriggerExit](https://docs.unity3d.com/ScriptReference/Collider.OnTriggerExit.html) : Appelée sur un GameObject qui possède un Collider en mode IsTrigger lorsqu'il cesse le contact avec un autre Collider.

### Créer et configurer un Trigger Collider

1. Créez un GameObject
	- Pour créer un Trigger Collider invisible, créez un GameObject vide. Dans la plupart des cas, ces colliders sont invisibles.
	- Pour créer un Trigger Collider visible, créez un GameObject doté d'un Mesh. Ce type de Collider n'a besoin d'être visible que s'il est possible pour d'autres GameObjects de le traverser de manière visible pendant le jeu.
2. Ajoutez un composant Collider au GameObject
3. Configurez le Collider comme un Trigger:
	- En éditeur, affichez l'inspecteur du Collider en question et cochez la propriété IsTrigger
	- En script, modifiez la propriété IsTrigger avec la valeur true

# Animations
## Quelques définitions

### Modèle 3D
Un modèle maillé 3D est un modèle numérique de surface qui représente numériquement un objet en 3D. Le modèle se compose de sommets(vertices), d'arêtes et d'éléments individuels(polygons).

Les sommets sont utilisés comme coordonnées et les arêtes du modèle relient respectivement deux sommets voisins. Les faces (polygones) englobent les arêtes et forment ainsi la surface de l'objet.

Les polygones les plus souvent utilisés sont les triangles et les quadrilatères. La composition de ces coordonnées, arêtes et polygones constitue le modèle de maillage 3D.

### Rig
Un rig est constitué d'une série d'articulations qui imitent la structure osseuse réelle et fournissent des points de pivot naturels entre les os. Le maillage du personnage est relié aux articulations par un processus appelé peinture pondérée, de sorte que les articulations et le maillage se déplacent ensemble.

> [!NOTE]
> Pour aller plus loin suivez ce [tutorial](https://learn.unity.com/tutorial/intro-to-unity-rigs#)

### Animation
Une série de transformations appliquées à chaque frame ou interpoler entre deux frames.

## Animer un objet
1. Sélectionner l'objet à animer
2. Ouvrir l'onglet "Animation"
3. Créer un nouvel animation clip (crée automatiquement un Animator et ajoute le composant sur l'objet)

## Animator
> [!NOTE]
> Plus de détails dans le [manuel](https://docs.unity3d.com/Manual/class-AnimatorController.html)

Un graph définissant les états possible d'un objet.
Chaque état défini une animation à jouer.
On définit des transitions pour passer d'un état à un autre.

![Image d'illustration](https://docs.unity3d.com/uploads/Main/MecanimAnimatorControllerWindow.png)

# L'interface utilisateur (UI)
## Le Canvas
> [!NOTE]
> Plus de détails dans le [manuel](https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/UICanvas.html)

Le Canvas est la zone dans laquelle tous les éléments de l'interface utilisateur doivent se trouver. 
Le Canvas est un gameobject avec un composant Canvas dessus, et tous les éléments de l'interface utilisateur doivent être des enfants de ce Canvas. 
Les éléments UI peuvent être configurés pour s'adapter ou s'étirer jusqu'à une position établie dans le Canvas.

![Image d'illustration](https://unity-connect-prd.storage.googleapis.com/20201103/learn/images/3b893a7f-c707-4dde-95e8-d5dbd58cbe36_93.png)

> [!TIP]
> Un cadre rectangulaire blanc dans la scène représente les limites visibles du Canvas.

### Modes de rendu
Le Canvas dispose d'un paramètre de mode de rendu qui peut être utilisé pour le rendre dans l'espace écran (Screen Space) ou dans l'espace 3D (World Space).

#### Screen Space - Overlay
Ce mode de rendu place les éléments de l'interface utilisateur sur l'écran rendu au-dessus de la scène. 
Si l'écran est redimensionné ou change de résolution, le Canvas changera automatiquement de taille pour correspondre à cela.

![Image d'illustration](https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/images/GUI_Canvas_Screenspace_Overlay.png)

#### Screen Space - Camera
Ce mode de rendu est similaire à Screen Space - Overlay, mais dans ce mode de rendu, le Canvas est placé à une distance donnée devant une caméra spécifiée. 
Les éléments de l'interface utilisateur sont rendus par cette caméra, ce qui signifie que les paramètres de la caméra affectent l'apparence de l'interface utilisateur.

#### World Space
Dans ce mode de rendu, le Canvas se comportera comme n'importe quel autre objet de la scène. 
La taille du Canvas peut être définie manuellement à l'aide de son composant Rect Transform, et les éléments de l'interface utilisateur s'afficheront devant ou derrière d'autres objets de la scène en fonction du placement 3D. 
Ceci est utile pour les interfaces utilisateur qui sont censées faire partie du monde. 

![Image d'illustration](https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/images/GUI_Canvas_Worldspace.png)

> [!NOTE]
> C'est ce qu'on appelle également une « interface diégétique ».

## Modifier les éléments UI
> [!NOTE]
> Plus de détails dans le [manuel](https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/UIBasicLayout.html)

Chaque élément de l'interface utilisateur est représenté sous forme de rectangle à des fins de mise en page. Ce rectangle peut être manipulé dans la vue de la scène à l'aide de l'outil Rect dans la barre d'outils.

L'outil Rect peut être utilisé pour déplacer, redimensionner et faire pivoter des éléments d'interface utilisateur. Une fois que vous avez sélectionné un élément d'interface utilisateur, vous pouvez le déplacer en cliquant n'importe où à l'intérieur du rectangle et en le faisant glisser.

![Image d'illustration](https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/images/GUI_Rect_Tool_Button.png)

Tout comme les autres outils, l'outil Rect utilise le mode de pivot et l'espace d'édition, définis dans la barre d'outils. Lorsque vous travaillez avec l'interface utilisateur, il est généralement judicieux de conserver ces paramètres sur Pivot et Local. Ainsi que de basculer la vue caméra en mode 2D.

![Image d'illustration](https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/images/GUI_Pivot_Local_Buttons.png)

### Pivot
Les rotations, les modifications de taille et d'échelle se produisent autour du pivot, de sorte que la position du pivot affecte le résultat d'une rotation, d'un redimensionnement ou d'une mise à l'échelle.

![Image d'illustration](https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/images/UI_PivotRotate.png)

### Ancres
Le composant Rect Transform inclu un concept de mise en page appelé ancres. 
Les ancres sont représentées par quatre petites poignées triangulaires dans la vue de la scène et les informations sur les ancres sont également affichées dans l'inspecteur.

![Image d'illustration](https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/images/UI_Anchored1.gif)

Si le parent d'un Rect Transform est également un Rect Transform, l'enfant peut être ancré au parent de différentes manières.

L'ancrage permet également à l'enfant de s'étirer en fonction de la largeur ou de la hauteur du parent. De cette façon, les différents coins du rectangle peuvent être ancrés à différents points du rectangle parent.

Les positions des ancres sont définies en fractions (ou pourcentages) de la largeur et de la hauteur du rectangle parent. 

![Image d'illustration](https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/images/UI_Anchored4.gif)

> [!IMPORTANT]
> 0,0 (0 %) correspond au côté gauche ou inférieur, 0,5 (50 %) au milieu et 1,0 (100 %) au côté droit ou supérieur.

Dans l'inspecteur, le bouton Anchor Preset se trouve dans le coin supérieur gauche du composant Transformation rectangulaire. Cliquez sur le bouton pour afficher la liste déroulante de presets. À partir de là, vous pouvez rapidement sélectionner certaines des options d'ancrage les plus courantes.

## Ratio et Résolution
> [!NOTE]
> Plus de détails dans le [manuel](https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/HOWTO-UIMultiResolution.html)

Les jeux et applications modernes doivent souvent prendre en charge une grande variété de résolutions d'écran différentes et les dispositions de l'interface utilisateur doivent notamment pouvoir s'adapter à cela.

Les éléments de l'interface utilisateur sont ancrés par défaut au centre du rectangle parent. Cela signifie qu'ils conservent un décalage constant par rapport au centre. Si la résolution est modifiée en format paysage avec cette configuration, les boutons pourraient carrément se retrouver en dehors de l'écran.

Une façon de conserver les boutons à l’intérieur de l’écran est de modifier la disposition de sorte que les emplacements des boutons soient liés à leurs coins respectifs de l’écran plutôt qu'au centre.

![Image d'illustration](https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/images/UI_MultiResCorners.png)

Lorsque la taille de l'écran est modifiée pour une résolution plus grande ou plus petite, les boutons restent également ancrés dans leurs coins respectifs. 
Cependant, comme ils conservent leur taille d'origine spécifiée en pixels, ils peuvent occuper une proportion plus ou moins grande de l'écran.

C'est là que le composant Canvas Scaler peut vous aider.
Vous pouvez définir son UI Scale Mode sur Scale With Screen Size. Avec ce mode d'échelle, vous pouvez spécifier une résolution à utiliser comme référence. Si la résolution d'écran actuelle est inférieure ou supérieure à cette résolution de référence, le facteur d'échelle du Canvas est défini en conséquence, de sorte que tous les éléments de l'interface utilisateur sont agrandis ou réduits en même temps que la résolution de l'écran.

> [!IMPORTANT]
> Une chose à savoir : après avoir ajouté un composant Canvas Scaler, il est important de vérifier également à quoi ressemble la mise en page dans d'autres rapports hauteur/largeur.

## Outils éditeur

Il existe différents outils dans l'éditeur pour simuler le rendu dans différents ratios ou configurations.

### Aspect Ratio
> [!NOTE]
> Plus de détails dans le [manuel](https://docs.unity3d.com/Manual/GameView.html)

Dans la fenêtre Game, cette option permet de tester l'apparence de votre jeu sur des écrans avec différents rapports hauteur/largeur. 

![Image d'illustration](https://docs.unity3d.com/uploads/Main/game-view-window.png)

Par défaut, le rapport hauteur/largeur est défini sur Free Aspect. Cela correspond finalement à tester le rendu uniquement dans les dimensions actuelles de la fenêtre. Donc potentiellement très loin de la réalité.

Vous pouvez changer cette configuration vers une configuration ou un ratio prédéfini. Ou bien créer une configuration personnalisée suivant vos besoins.

### Simulator view
> [!NOTE]
> Plus de détails dans le [manuel](https://docs.unity3d.com/Manual/device-simulator-view.html)

Utilisez la vue Simulateur pour prévisualiser l'apparence de votre application créée sur un appareil mobile.

![Image d'illustration](https://docs.unity3d.com/uploads/Main/device-simulator-view.png)

Pour basculer entre les vues Game et Simulator, dans l'onglet Game/Simulator, sélectionnez une option dans le menu.

Vous pouvez également ouvrir la vue Simulator en allant dans Window > General et en sélectionnant Device Simulator. Si aucune instance de la vue Simulator n'est ouverte, elle s'ouvre sous forme de fenêtre flottante.

## Interagir avec les éléments UI
> [!NOTE]
> Plus de détails dans le [manuel](https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/UIInteractionComponents.html)

Canvas utilise l'objet EventSystem pour transmettre des messages entre l'interface et le code.
Cet objet est ajouté automatiquement dans la scène à la création d'un nouvel objet Canvas et est indispensable pour que les éléments interactifs de l'interface fonctionnent.

La plupart des composants d'interaction ont des points communs. Ils sont sélectionnables, ce qui signifie qu'ils partagent une fonctionnalité intégrée pour visualiser les transitions entre les états.

Les composants d'interaction ont au moins un UnityEvent qui est invoqué lorsque l'utilisateur interagit avec le composant d'une manière spécifique. Le système d'interface utilisateur détecte et enregistre toutes les exceptions qui se propagent hors du code attaché à UnityEvent.

# Cinemachine

## Installation

> [!NOTE]
> Plus de détails dans le [manuel](https://docs.unity3d.com/Manual/upm-ui.html)

Cinemachine est un package qui n'est pas inclus par défaut dans un nouveau projet.
Il est donc nécessaire de l'importer comme tout autre package Unity.

1. Ouvrez la fenêtre Window / Package Manager
2. Sélectionnez la catégorie Unity Registry
3. Installez le package Cinemachine

## Éléments essentiels

> [!NOTE]
> Plus de détails dans le [manuel](https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/concept-essential-elements.html)

Une configuration Cinemachine fonctionnelle implique trois principaux types d'éléments :

- Une seule caméra Unity qui capture les images de la scène
- Un Cinemachine Brain qui active la fonctionnalité Cinemachine dans la caméra Unity
- Une ou plusieurs Cinemachine Cameras qui contrôlent à tour de rôle la caméra Unity en fonction de leur statut

## La Caméra Unity

> [!NOTE]
> Plus de détails dans le [manuel](https://docs.unity3d.com/2022.3/Documentation/Manual/class-Camera.html)

La caméra Unity est un GameObject qui inclut un composant Camera, par opposition aux caméras Cinemachine.

### Projection
Active ou désactive la capacité de la caméra à simuler la perspective.

#### Perspective
La caméra rendra les objets avec une perspective intacte.
Utilisez les paramètres de Field of View pour contrôler l'angle de vue de la caméra.
Mesuré en degrés selon l'axe spécifié dans FOV Axis.

![Image d'illustration](https://docs.unity3d.com/2022.3/Documentation/uploads/Main/Camera-Non-Ortho-FPS.jpg)

#### Orthographic
La caméra rendra les objets de manière uniforme, sans aucun sens de la perspective.
Contrôlez la zone visible par l’utilisateur sur son écran (viewport) grâce au paramètre Size. 

![Image d'illustration](https://docs.unity3d.com/2022.3/Documentation/uploads/Main/Camera-Ortho-FPS.jpg)

## Cinemachine Brain

> [!NOTE]
> Plus de détails dans le [manuel](https://docs.unity3d.com/Packages/com.unity.cinemachine@2.10/manual/CinemachineBrainProperties.html)

Pour fonctionner avec Cinemachine, le GameObject qui porte la Camera doit inclure un composant Cinemachine Brain.

Les GameObject dotés d'un Cinemachine Brain sont affichés dans la hiérarchie avec une petite icône CinemachineCamera à côté d'eux. Vous pouvez désactiver cette option à partir du panneau Préférences Cinemachine.

Ce composant est responsable de :
- Surveiller toutes les caméras Cinemachine actives dans la scène.
- Déterminer quelle caméra Cinemachine contrôle la caméra Unity.
- Gérer la transition lorsqu'une autre caméra Cinemachine prend le contrôle de la caméra Unity.

![Image d'illustration](https://docs.unity3d.com/Packages/com.unity.cinemachine@2.10/manual/images/CinemachineBrain.png)

Pour ajouter un composant Cinemachine Brain à une caméra Unity, effectuez l'une des opérations suivantes :

- Utilisez le menu GameObject > Cinemachine pour ajouter une CinemachineCamera à votre scène. Unity ajoute un composant Cinemachine Brain à la caméra Unity pour vous s'il n'y en a pas déjà un.
- Ajoutez vous-même un composant Cinemachine Brain à la caméra Unity.

## Cinemachine Camera (Virtual Camera)

> [!NOTE]
> Plus de détails dans le [manuel](https://docs.unity3d.com/Packages/com.unity.cinemachine@2.10/manual/CinemachineVirtualCamera.html)

La CinemachineCamera est un composant que vous ajoutez à un GameObject vide. Il représente une Cinemachine Camera dans la scène Unity.

![Image d'illustration](https://docs.unity3d.com/Packages/com.unity.cinemachine@2.10/manual/images/CinemachineVCamProperties.png)

Utilisez les propriétés Aim, Body et Noise pour spécifier la manière dont la caméra virtuelle anime la position, la rotation et d'autres propriétés. La caméra virtuelle applique ces paramètres à la caméra Unity lorsque Cinemachine Brain transfère le contrôle de la caméra Unity à la caméra virtuelle prioritaire.

### Priority
Ce paramètre contrôle la manière dont la sortie de cette CinemachineCamera est utilisée par CinemachineBrain. 

À tout moment, chaque caméra virtuelle peut être dans l’un de ces états en fonction des valeurs de priorité :

- Live: La caméra virtuelle contrôle activement une caméra Unity dotée d'un cerveau Cinemachine.
- Standby: La caméra virtuelle ne contrôle pas la caméra Unity. Cependant, elle suit et vise toujours ses cibles et se met à jour à chaque image.
- Disabled: La caméra virtuelle ne contrôle pas la caméra Unity et ne suit ni ne vise activement ses cibles.

### Follow
L'objet GameObject cible avec lequel la caméra virtuelle se déplace. Les propriétés Body utilisent cette cible pour mettre à jour la position de la caméra Unity.

### Body

> [!NOTE]
> Plus de détails dans le [manuel](https://docs.unity3d.com/Packages/com.unity.cinemachine@2.10/manual/CinemachineVirtualCameraBody.html)

Utilisez les propriétés Body pour spécifier l’algorithme qui déplace la caméra virtuelle dans la scène.

Différents algorithmes sont détaillés dans la documentation pour répondre aux besoins variés de suivi du GameObject cible. Mais un des principaux reste le mode 3rd Person follow qui permet de pivoter la caméra horizontalement et verticalement autour du joueur en suivant la cible Follow.

### Aim

> [!NOTE]
> Plus de détails dans le [manuel](https://docs.unity3d.com/Packages/com.unity.cinemachine@2.10/manual/CinemachineVirtualCameraAim.html)

Utilisez les propriétés Aim pour spécifier comment faire pivoter la caméra virtuelle.

Les principaux algorithmes utilisés sont Composer et Group Composer, qui permettent respectivement de garder une ou plusieurs cibles dans le cadre de la caméra.

## Transitions

> [!NOTE]
> Plus de détails dans le [manuel](https://docs.unity3d.com/Packages/com.unity.cinemachine@2.10/manual/CinemachineBlending.html)

Utilisez les propriétés de Blend pour spécifier comment le composant Cinemachine Brain effectue un blend entre les caméras virtuelles.

Un Blend Cinemachine n'est pas un fade. Au contraire, Cinemachine Brain effectue une animation fluide de la position, de la rotation et d'autres paramètres de la caméra Unity d'une caméra virtuelle à l'autre.

Pour les fusions entre des caméras virtuelles spécifiques, utilisez la liste Custom Blends dans le composant Cinemachine Brain. Utilisez la propriété Default Blend dans Cinemachine Brain pour spécifier des fusions entre des caméras virtuelles qui n'ont pas de blending personnalisé.

![Image d'illustration](https://docs.unity3d.com/Packages/com.unity.cinemachine@2.10/manual/images/CinemachineCustomBlends.png)

> [!TIP]
> Utilisez le nom réservé **ANY CAMERA** pour effectuer un blend depuis ou vers n'importe quelle caméra virtuelle.

# La lumière
Les rayons de lumière rebondissent sur les objets qui nous entourent.
Chaque rayon réagit en fonction des propriétés des matériaux rencontrés lors de chaque rebond (fréquence, direction, etc).
Une fois que ces rayons atteignent l'œil, le cerveau interprète ce qui "reste" de la lumière pour déterminer notre environnement.

> [!NOTE]
> Plus de détails dans le [manuel](https://docs.unity3d.com/2022.3/Documentation/Manual/LightingInUnity.html)

## Éclairage direct et indirect
On parle d'éclairage direct lorsque le rayon de lumière atteint l'œil après avoir rebondi une seule fois sur un objet.
A l'inverse un éclairage indirect correspond aux multiples rebonds d'un rayon de lumière avant qu'il n'atteigne l'œil.
C'est cette partie de l'éclairage qui est compliqué à calculer de manière réaliste.
En informatique on va donc contraindre le nombre de rebonds (généralement 3 maximum) pour réduire les calculs à réaliser.

## Temps réel et précalculé
L'éclairage en temps réel (**realtime**) est utilisé lorsque Unity calcule l'éclairage au moment de l'exécution. 
L'éclairage précalculé (**baked**) est utilisé lorsque Unity effectue des calculs d'éclairage à l'avance et enregistre les résultats sous forme de données d'éclairage, qui sont ensuite appliquées au moment de l'exécution. 
 
Dans Unity, votre projet peut utiliser un éclairage en temps réel, un éclairage précalculé ou un mélange des deux (appelé éclairage mixte).

## Éclairage global
Unity dispose de deux systèmes d'éclairage global, qui combinent l'éclairage direct et indirect.
Le système d'illumination globale en temps réel est [Enlighten Realtime Global Illumination](https://docs.unity3d.com/2022.3/Documentation/Manual/realtime-gi-using-enlighten.html).
Cela va par exemple permettre d'éclairer des objets avec une lumière vacillante.

> [!NOTE]
> Son usage est conseillé pour les plateformes suffisamment robustes pour gérer le calcul de ces changements à chaque frame.
> En général les plateformes mobiles vont éviter ce type d'éclairage et se rabattre sur un éclairage précalculé.

Le système Baked Global Illumination se compose de lightmaps, de light probs et de reflection probes qu'il est possible de précalculé avec le [Progressive Lightmapper](https://docs.unity3d.com/2022.3/Documentation/Manual/progressive-lightmapper.html).
Ce système permet de générer les données d'éclairage dans une scène et sur les objets quelle contient pendant l'édition plutôt que l'éxécution. 

> [!IMPORTANT]
> Il est important de noter que l'éclairage précalculé ne fonctionne que pour les objets statiques dans la scène.
> Par ailleurs cela nécessite des UV non superposés avec de petites erreurs de surface et d'angle.

> [!TIP]
> Il est nécessaire de cocher la propriété Generate Lightmaps UVs sur les objets importés dans Unity si ces UVs n'ont pas été créées préalablement dans l'outil de modelling 3D.
> ![image](https://github.com/user-attachments/assets/390a5d12-bf32-4811-921e-f9819b25163f)

## Éclairage ambiant
Toute nouvelle scène créée dans Unity est déjà éclairée de deux façons : 
	1. Un éclairage ambiant de base (fenêtre lighting-->settings).
	2. Une lumière directionnelle présente dans l'onglet hierarchy 
 
Même en désactivant toutes les sources de lumière dans votre environnement, ce dernier reste légèrement éclairé par la lumière ambiante qui éclaire tous les objets de façon égale. 
Pour contrôler et modifier cet éclairage ambiant, choisir le menu Window/Renderin/LightingSettings, puis l'onglet Scene.

## Éclairage par composant

> [!NOTE]
> Plus de détails dans le [manuel](https://docs.unity3d.com/2022.3/Documentation/Manual/Lighting.html)

Vous pouvez ajouter des lumières à votre scène à partir du menu GameObject->Light. 
Vous choisirez le format de lumière que vous souhaitez dans le sous-menu qui apparaît. 
Une fois qu'une lumière a été ajoutée, vous pouvez la manipuler comme n'importe quel autre GameObject. 
De plus, vous pouvez ajouter un composant Light à n'importe quel GameObject sélectionné en utilisant Component->Rendering->Light.

Plusieurs types de lumières son disponibles avec ce composant.
![image](https://github.com/user-attachments/assets/6e414466-8bff-49e8-a023-69bdf59cf868)

### Lumière directionnelle (Directional light)
Ce comportant de nombreuses façons comme le soleil, les lumières directionnelles peuvent être considérées comme des sources lumineuses distantes qui existent à une distance infinie. 
Une lumière directionnelle n'a pas de position source identifiable et l'objet lumineux peut donc être placé n'importe où dans la scène.

> [!TIP]
> La rotation de la lumière directionnelle par défaut entraîne la mise à jour de la **Skybox**.
> Si la Skybox est sélectionnée comme source ambiante, l'éclairage ambiant changera en fonction de ces couleurs. 
> Avec la lumière orientée vers le côté, parallèlement au sol, des effets de coucher de soleil peuvent être obtenus.
> En pointant la lumière vers le haut, le ciel devient noir, comme s'il faisait nuit.
> Avec la lumière orientée vers le bas, le ciel ressemblera à la lumière lorsque le soleil est au zénith.

### Point de lumière (point light)
Un point lumineux est situé à un point de l'espace et envoie de la lumière dans toutes les directions de manière égale. 
La direction de la lumière frappant une surface est la ligne reliant le point de contact au centre de l'objet lumineux. 
L'intensité diminue avec la distance par rapport à la lumière.

### Lumière spot (spotlight)
Tout comme un point de lumière, un spot a un emplacement et une portée spécifiques sur lesquels la lumière tombe. 
Cependant, un spot est limité à un angle, ce qui donne une zone d'éclairage en forme de cône.
Cela est généralement utilisé pour les sources de lumière artificielle telles que les lampes de poche, les phares de voiture et les projecteurs.

### Lumière de zone (area light)
Vous pouvez définir une lumière de zone par l'une des deux formes dans l'espace : un rectangle ou un disque. 
Une lumière de zone émet de la lumière depuis un côté de cette forme. 
La lumière émise se propage uniformément dans toutes les directions sur la surface de cette forme.
 
> [!IMPORTANT]
> Étant donné que ce calcul d’éclairage nécessite beaucoup de ressources processeur, les lumières de zone ne sont pas disponibles en temps-réel et ne peuvent être intégrées que dans des lightmaps précalculées.

## Éclairage provenant d'un objet (Emissive)

> [!NOTE]
> Plus de détails dans le [manuel](https://docs.unity3d.com/2022.3/Documentation/Manual/lighting-emissive-materials.html)

Il est possible d'ajuster les propriétés du matériel d'un objet pour qu'il émette de la lumière.
Ces objets contribuent à la lumière réfléchie dans votre scène et les propriétés associées telles que la couleur et l'intensité peuvent être modifiées pendant le jeu.
 
L'émission ne sera reçue que par les objets marqués comme « Static » ou « Lightmap Static » dans l'inspecteur.
De même, les matériaux émissifs appliqués à une géométrie non statique ou dynamique telle que des personnages ne contribueront pas à l’éclairage de la scène.

# L'Audio

> [!NOTE]
> Plus de détails dans le [manuel](https://docs.unity3d.com/Manual/AudioOverview.html)

Pour simuler les effets de position, Unity nécessite que les sons proviennent d'Audio Source attachées à des objets.
Les sons émis sont ensuite captés par un Audio Listener attaché à un autre objet, le plus souvent la caméra principale.

![image](https://docs.unity3d.com/uploads/Main/AudioSourceListDiagram.png)

> [!TIP]
> Unity ne peut pas calculer les échos uniquement à partir de la géométrie de la scène, mais vous pouvez les simuler en ajoutant des filtres audio aux objets.

## Les Formats
Unity peut importer des fichiers audio aux formats AIFF, WAV, MP3 et Ogg de la même manière que d'autres ressources.
Importez un fichier audio pour créer un clip audio que vous pouvez ensuite faire glisser vers une source audio ou utiliser à partir d'un script.

## Audio Source

> [!NOTE]
> Plus de détails dans le [manuel](https://docs.unity3d.com/Manual/class-AudioSource.html)

La source audio lit un clip audio dans la scène.
Le clip peut être lu par un Audio Listener ou via un mixeur audio.
L'audio peut être réparti entre les différents haut-parleurs de la plateforme (stéréo vers 7.1) (Spread).
Il peut être également transformé entre 3D et 2D (SpatialBlend).
L'audio peut être atténué avec la distance par l'intermédiaire de courbes de décroissance.

Il est possible de faire tourner le clip audio en boucle lorsqu'il atteint la fin en activant la propriété Loop.
Vous pouvez définir la quantité de changement de hauteur (Pitch) due au ralentissement/à l'accélération du clip audio. La valeur 1 correspond à la vitesse de lecture normale.

![image](https://docs.unity3d.com/uploads/Main/AudioSourceInspector.png)

Pour créer une nouvelle source audio :
	
- Importez vos fichiers audio dans votre projet Unity. Ce sont désormais des clips audio.
- Créez un GameObject de source audio (menu : GameObject > Audio > Audio Source).
- Avec le nouveau GameObject sélectionné, sélectionnez Composant > Audio > Audio Source.

Dans l'inspecteur, recherchez la propriété Clip audio sur le composant Audio Source et attribuez un clip, soit en le faisant glisser depuis la fenêtre de projet, soit en cliquant sur la petite icône en forme de cercle à droite de la propriété Inspecteur, puis en sélectionnant un clip dans la liste.
	
> [!TIP]
> Si vous souhaitez créer une source audio uniquement pour un clip audio que vous avez dans le dossier Assets, vous pouvez simplement faire glisser ce clip vers la vue de la scène - un GameObject avec un composant Source audio sera créé automatiquement pour celui-ci.

## Audio Listener

> [!NOTE]
> Plus de détails dans le [manuel](https://docs.unity3d.com/Manual/class-AudioListener.html)

Il reçoit les entrées de n'importe quelle source audio donnée dans la scène et diffuse les sons via la sortie son de la plateforme. 

En fonction de la perspective du joueur, il peut être plus judicieux de connecter l'Audio Listener à la caméra principale (expérience à la première personne par exemple). Cependant, si la caméra est détachée de la représentation du joueur, vous devez alors déterminer où l'Audio Listener s'intègre le mieux (éventuellement près de la tête du personnage principal).

L'Audio Listener n'a pas de propriétés. Il doit simplement être ajouté pour fonctionner. Il est toujours ajouté à la caméra principale par défaut.

Lorsque l'Audio Listener est attaché à un GameObject dans votre scène, toutes les sources suffisamment proches de seront captées et transmises à la sortie son de la plateforme.

> [!IMPORTANT]
> Chaque scène ne peut avoir qu'un seul Audio Listener pour fonctionner correctement.

Si les sources sont en 3D, l'Audio Listener émulera la position, la vitesse et l'orientation du son dans le monde 3D. 2D ignorera tout traitement 3D.
